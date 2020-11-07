using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace OrganisationData.Models
{
    public class AppUser:DbContext
    {
        public AppUser(DbContextOptions<AppUser>options):base (options)
        {

        }
        public DbSet<UserReg> LoginUser { get; set; }
    }
}
