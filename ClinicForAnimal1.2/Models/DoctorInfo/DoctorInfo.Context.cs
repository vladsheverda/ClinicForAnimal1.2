namespace ClinicForAnimal1._2.Models.DoctorInfo
{
    using System.Data.Entity;

    public partial class ClinicForAnimalEntities : DbContext
    {
        public ClinicForAnimalEntities()
            : base("name=ClinicForAnimalEntities")
        {
        }
    
      
    
        public virtual DbSet<DoctorInfoForAdmin> DoctorInfoForAdmins { get; set; }
    }
}
