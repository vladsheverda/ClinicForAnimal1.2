﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClinicForAnimal1._2.Models.Services.Category
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CategoryForServices : DbContext
    {
        public CategoryForServices()
            : base("name=CategoryForServices")
        {
        }
    
        public virtual DbSet<CategoryService> CategoryServices { get; set; }

        public System.Data.Entity.DbSet<ClinicForAnimal1._2.Models.Services.Services.VeterinarianService> VeterinarianServices { get; set; }
    }
}
