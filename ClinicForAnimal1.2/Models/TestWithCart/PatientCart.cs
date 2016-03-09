using ClinicForAnimal1._2.Models.Users;

namespace ClinicForAnimal1._2.Models.TestWithCart
{
    public class PatientCart
    {
        public int Id { get; set; }
        public string Diagnoses { get; set; }
        public string Treatment { get; set; }

        public string IdUser { get; set; }
        public AspNetUser Users { get; set; }
    }
}