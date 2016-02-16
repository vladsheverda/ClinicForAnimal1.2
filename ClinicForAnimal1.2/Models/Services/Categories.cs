using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClinicForAnimal1._2.Models.Services
{
    public class Categories
    {
        public IEnumerable<VeterinarianService> Services { get; set; }
        public string CurrentCategory { get; set; }
    }
}