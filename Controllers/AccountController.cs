using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Mail;
using System.Security.Claims;
using System.Threading.Tasks;
using KoronaTakipV2.Models.Data;
using KoronaTakipV2.Models.LoginModels;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using MailKit.Net.Smtp;
using SmtpClient = MailKit.Net.Smtp.SmtpClient;

namespace KoronaTakipV2.Controllers
{
    public class AccountController : Controller
    {

        private UserManager<MavIdentityUser> _userManager;
        private SignInManager<MavIdentityUser> _signInManager;
        private IHttpContextAccessor _httpContextAccessor;

        public AccountController(UserManager<MavIdentityUser> userManager,
                                 SignInManager<MavIdentityUser> signInManager,
                                 IHttpContextAccessor httpContextAccessor)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _httpContextAccessor = httpContextAccessor;
        }


        
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel loginViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(loginViewModel);
            }

            var user = await _userManager.FindByNameAsync(loginViewModel.UserName);
            var userId = user.Id;
            if (user!=null)
            {

                if (!await _userManager.IsEmailConfirmedAsync(user))
                {
                    ModelState.AddModelError(string.Empty, "Lütfen e-postanızı onaylayın!");
                    return View(loginViewModel);
                }
            }

            var result = await _signInManager.PasswordSignInAsync(loginViewModel.UserName, loginViewModel.Password, loginViewModel.RememberMe, false);

            if (result.Succeeded)
            {
                HttpContext.Session.SetString("userId", userId);
                HttpContext.Session.SetString("userName", loginViewModel.UserName);
                return RedirectToAction("Index", "Admin");
            }
            ModelState.AddModelError(string.Empty, "Giriş başarısız !");
            return View(loginViewModel);

        }
        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Login", "Account");
        }

        //public ActionResult Register()
        //{
        //    return View();
        //}

        //[HttpPost,ValidateAntiForgeryToken]
        //public ActionResult Register(RegisterViewModel registerViewModel)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return View(registerViewModel);
        //    }

        //    var user = new MavIdentityUser
        //    {
        //        UserName = registerViewModel.UserName,
        //        FirstName = registerViewModel.FirstName,
        //        LastName = registerViewModel.LastName,
        //        Email = registerViewModel.Email
        //    };

        //    if (registerViewModel.Password!=registerViewModel.ConfirmPassword)
        //    {
        //        ModelState.AddModelError("confirmError", "Şifreler uyuşmuyor");
        //        return View(registerViewModel);
        //    }

        //    var result = _userManager.CreateAsync(user, registerViewModel.Password).Result;
        //    if (result.Succeeded)
        //    {
        //        var confirmationCode = _userManager.GenerateEmailConfirmationTokenAsync(user);
        //        var callBackUrl = Url.Action("ConfirmEmail", "Account",
        //            new { userId = user.Id, code = confirmationCode.Result });

        //        var myUrl = $"{_httpContextAccessor.HttpContext.Request.Scheme}://{_httpContextAccessor.HttpContext.Request.Host}";

        //        var message = new MimeMessage();

        //        message.From.Add(new MailboxAddress("Erbay Mavzer", "erbaymavzer35@gmail.com"));

        //        message.To.Add(new MailboxAddress(registerViewModel.FirstName, registerViewModel.Email));

        //        message.Subject = $"Hoşgeldin {registerViewModel.FirstName}, mail doğrulama kodun burada";

        //        message.Body = new TextPart("plain")
        //        {
        //            Text =  myUrl + callBackUrl 
                                        
        //        };

        //        using (var client = new SmtpClient())
        //        {
        //            client.Connect("smtp.gmail.com", 587, false);
        //            client.Authenticate("erbaymavzer35@gmail.com", "konal421");
        //            client.Send(message);
        //            client.Disconnect(true);
        //        }

        //        return RedirectToAction("Login","Account");
        //    }
        //    return View(registerViewModel);
        //}

        //public async Task<ActionResult> ConfirmEmail(string userId,string code)
        //{
        //    if (userId==null||code==null)
        //    {
        //        TempData.Add("message", "Kullanıcı veya onay kodu bulanamadı.");
        //        return RedirectToAction("Login", "Account");
        //    }

        //    var user = await _userManager.FindByIdAsync(userId);
        //    if (user==null)
        //    {
        //        TempData.Add("message", "Böyle bir kullanıcı bulunamadı");
        //        return RedirectToAction("Login", "Account");
        //    }

        //    var result = await _userManager.ConfirmEmailAsync(user, code);
        //    if (result.Succeeded)
        //    {
        //        return View("ConfirmEmail");
        //    }
        //    return RedirectToAction("Index", "Admin");
        //}

        //public ActionResult ForgotPassword()
        //{
        //    return View();
        //}

        //[HttpPost,ValidateAntiForgeryToken]
        //public async Task<ActionResult> ForgotPassword(string email)
        //{
        //    if (string.IsNullOrEmpty(email))
        //    {
        //        return View();
        //    }

        //    var user = await _userManager.FindByEmailAsync(email);
        //    if (user==null)
        //    {
        //        return View();
        //    }

        //    var confirmationCode = await _userManager.GeneratePasswordResetTokenAsync(user);
        //    var callBackUrl = Url.Action("ResetPassword", "Account", new { userId = user.Id, code = confirmationCode });

        //    var myUrl =
        //        $"{_httpContextAccessor.HttpContext.Request.Scheme}://{_httpContextAccessor.HttpContext.Request.Host}";

        //    var message = new MimeMessage();

        //    message.From.Add(new MailboxAddress("Erbay MAVZER", "erbaymavzer35@gmail.com"));

        //    message.To.Add(new MailboxAddress(user.FirstName, user.Email));

        //    message.Subject = $"Welcome {user.FirstName}, here your code for reset to your password";

        //    message.Body = new TextPart("plain")
        //    {
        //        Text = myUrl + callBackUrl
        //    };
        //    using (var client = new SmtpClient())
        //    {
        //        client.Connect("smtp.gmail.com", 587, false);
        //        client.Authenticate("erbaymavzer35@gmail.com", "konal421");
        //        client.Send(message);
        //        client.Disconnect(true);
        //    }

        //    return RedirectToAction("ForgotPasswordEmailSend", "Account");
        //}

        //public ActionResult ForgotPasswordEmailSend()
        //{
        //    TempData.Add("message", "Şifrenizi sıfırlamak için lütfen e-postanızı kontrol edin!");
        //    return RedirectToAction("Login", "Account");
        //}

        //public ActionResult ResetPassword(string userId, string code)
        //{
        //    if (userId == null || code == null)
        //    {
        //        throw new ApplicationException("Parola sıfırlama için kullanıcı kimliği veya kodu sağlanmalıdır");
        //    }
        //    var model = new ResetPasswordViewModel();
        //    return View(model);
        //}

        //[HttpPost, ValidateAntiForgeryToken]
        //public async Task<ActionResult> ResetPassword(ResetPasswordViewModel resetPasswordViewModel)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return View(resetPasswordViewModel);
        //    }

        //    var user = await _userManager.FindByEmailAsync(resetPasswordViewModel.Email);
        //    if (user == null)
        //    {
        //        throw new ApplicationException("Kullanıcı bulunamadı!");
        //    }

        //    var result =
        //        await _userManager.ResetPasswordAsync(user, resetPasswordViewModel.Code,
        //            resetPasswordViewModel.Password);
        //    if (result.Succeeded)
        //    {
        //        if (resetPasswordViewModel.Password == resetPasswordViewModel.ConfirmPassword)
        //        {
        //            TempData.Add("message", "Şifreniz sıfırlandı");
        //            return RedirectToAction("Index", "Home");
        //        }
        //        ModelState.AddModelError("confirm", "Şifreler eşleşmedi");
        //        return View(resetPasswordViewModel);
        //    }

        //    return View();
        //}
    }
}