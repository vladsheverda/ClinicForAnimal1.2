
namespace ClinicForAnimal1._2.Models.Users
{
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    public partial class Users : DbContext
    {
        public Users()
            : base("name=Users")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
    }
}
