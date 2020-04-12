using KoronaTakipV2.Models.AdminObjects;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KoronaTakipV2.ViewComponents
{
    public class UserViewComponent:ViewComponent
    {
        public ViewViewComponentResult Invoke()
        {
            UserDetailsViewModel model = new UserDetailsViewModel
            {
                UserName = HttpContext.User.Identity.Name
            };
            return View(model);
        }
    }
}
