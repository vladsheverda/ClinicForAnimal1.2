namespace ClinicForAnimal1._2.Models.DoctorInfo
{
    using System.Data.Entity;

    public partial class DoctorInfoEntities : DbContext
    {
        public DoctorInfoEntities()
            : base("name=DoctorInfoEntities")
        {
        }



        public virtual DbSet<DoctorInfoForAdmin> DoctorInfoForAdmin { get; set; }
    }
}
