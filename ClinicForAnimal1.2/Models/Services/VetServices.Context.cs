namespace ClinicForAnimal1._2.Models.Services
{
    using System.Data.Entity;

    public partial class VerServices : DbContext
    {
        public VerServices()
            : base("name=VerServices")
        {
        }
    
        public virtual DbSet<VeterinarianService> VeterinarianServices { get; set; }

        public System.Data.Entity.DbSet<ClinicForAnimal1._2.Models.Reviews.Review> Reviews { get; set; }
    }
}
