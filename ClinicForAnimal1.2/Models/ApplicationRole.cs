using Microsoft.AspNet.Identity.EntityFramework;

namespace ClinicForAnimal1._2.Models
{
    public class ApplicationRole:IdentityRole
    {
        public ApplicationRole()
        {

        }
        public string Description { get; set; }
    }
}