using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ClinicForAnimal1._2.Models
{
    public class ApplicationContext:IdentityDbContext<ApplicationUser>
    {
        public ApplicationContext():base("IdentityDb")
        {

        }
        public static ApplicationContext Create()
        {
            return new ApplicationContext();
        }

        public DbSet<ApplicationRole> IdentityRoles { get; set; }

        public DbSet<EditRoleModel> EditRoleModels { get; set; }
    }
}