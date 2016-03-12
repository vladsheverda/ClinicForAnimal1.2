using System;
using System.Collections.Generic;

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
    public class PatientViewModel
    {
        public int IdCaseRecord { get; set; }
        public string Diagnosis { get; set; }
        public string Treatment { get; set; }
        public string IdPatient { get; set; }

        public AspNetUser AspNetUsers { get; set; }

        internal static List<PatientViewModel> Parse(AspNetUser user)
        {
            List<PatientViewModel> model = new List<PatientViewModel>();
            foreach (var entry in user.CartForPatients)
            {
                model.Add(new PatientViewModel()
                {
                    Diagnosis = entry.Diagnosis,
                    Treatment = entry.Treatment
                });
            }
            return model;
        }
    }
}
