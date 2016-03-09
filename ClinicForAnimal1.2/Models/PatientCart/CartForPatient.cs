namespace ClinicForAnimal1._2.Models.PatientCart
{

    public partial class CartForPatient
    {
        public int IdCaseRecord { get; set; }
        public string Diagnosis { get; set; }
        public string Treatment { get; set; }
        public string IdPatient { get; set; }
    
        public virtual AspNetUser AspNetUser { get; set; }
    }
}
