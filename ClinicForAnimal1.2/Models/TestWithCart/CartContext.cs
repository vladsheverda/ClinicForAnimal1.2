using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ClinicForAnimal1._2.Models.TestWithCart
{
    public class CartContext:DbContext
    {
        public CartContext():base("Carts")
        { }
        public DbSet<PatientCart> Carts { get; set; }
    }
}