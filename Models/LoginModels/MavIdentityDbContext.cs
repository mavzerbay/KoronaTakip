using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KoronaTakipV2.Models.LoginModels
{
    public class MavIdentityDbContext:IdentityDbContext<MavIdentityUser,MavIdentityRole,string>
    {
        public MavIdentityDbContext(DbContextOptions<MavIdentityDbContext>options):base(options)
        {

        }
    }
}
