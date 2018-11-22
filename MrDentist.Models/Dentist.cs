using System.Collections.Generic;

namespace MrDentist.Models
{
    public class Dentist : Person
    {
        public string ProfessionalRegister { get; set; }
        public List<Patient> Patients { get; private set; }

        public Dentist(int id) : base(id)
        {
            Patients = new List<Patient>();
        }
    }
}
