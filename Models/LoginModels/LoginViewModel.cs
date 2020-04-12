using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KoronaTakipV2.Models.LoginModels
{
    public class LoginViewModel
    {
        [Required, Display(Name = "User Name")]
        public string UserName { get; set; }
        [Required, Display(Name = "Password"), DataType(DataType.Password)]
        public string Password { get; set; }
        [Required, Display(Name = "Remember Me")]
        public bool RememberMe { get; set; }
    }
}
