using Microsoft.AspNet.Identity.EntityFramework;

namespace ClinicForAnimal1._2.Models
{
    public class ApplicationUser : IdentityUser
    {
        public int Age { get; set; }
        public ApplicationUser()
        {

        }
    }
}