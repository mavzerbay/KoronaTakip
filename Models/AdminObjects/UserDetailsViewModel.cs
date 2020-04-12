using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KoronaTakipV2.Models.AdminObjects
{
    public class UserDetailsViewModel
    {
        public string UserName { get; set; }
        public string UserId { get; internal set; }
    }
}
