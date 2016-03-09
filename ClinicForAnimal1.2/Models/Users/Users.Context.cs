

namespace ClinicForAnimal1._2.Models.Users
{
    using System.Data.Entity;

    public partial class Users : DbContext
    {
        public Users()
            : base("name=Users")
        {
        }
    
    
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
    }
}
