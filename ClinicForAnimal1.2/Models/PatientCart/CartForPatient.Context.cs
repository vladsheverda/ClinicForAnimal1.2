namespace ClinicForAnimal1._2.Models.PatientCart
{
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    public partial class PatientCart : DbContext
    {
        public PatientCart()
            : base("name=PatientCart")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CartForPatient> CartForPatient { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
    }
}
