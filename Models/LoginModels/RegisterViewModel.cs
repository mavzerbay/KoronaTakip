using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KoronaTakipV2.Models.LoginModels
{
    public class RegisterViewModel
    {
        [Remote("Register", "Account", HttpMethod = "POST", ErrorMessage = "Kullanıcı zaten kayıtlı."), Required(AllowEmptyStrings = false, ErrorMessage = "Lütfen kullanıcı adı girin."), Display(Name = "Kullanıcı Adı"), RegularExpression("^[a-zA-Z0-9ğüşöçİĞÜŞÖÇ]+$")]
        public string UserName { get; set; }
        [Required, Display(Name = "Ad")]
        public string FirstName { get; set; }
        [Required, Display(Name = "Soyad")]
        public string LastName { get; set; }
        [Required, Display(Name = "Şifre"), DataType(DataType.Password)]
        public string Password { get; set; }
        [Required, Compare(nameof(Password), ErrorMessage = "Şifreniz uyuşmuyor"), Display(Name = "Şifreyi Onayla"), DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
        [Display(Name = "E-mail"), DataType(DataType.EmailAddress), Remote("Register", "Account", HttpMethod = "POST", ErrorMessage = "E-posta zaten kayıtlı."), Required(AllowEmptyStrings = false, ErrorMessage = "Lütfen E-posta girin.")]
        public string Email { get; set; }
    }
}
