using System.Collections.Generic;

namespace ClinicForAnimal1._2.Models.Services
{
    public class Categories
    {
        public IEnumerable<VeterinarianService> Services { get; set; }
        public string CurrentCategory { get; set; }
    }
}