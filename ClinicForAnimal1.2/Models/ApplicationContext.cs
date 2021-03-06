﻿using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using ClinicForAnimal1._2.Models.DoctorInfo;

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

        public DbSet<DoctorInfoForAdmin> DoctorInfoForAdmins { get; set; }
    }
}