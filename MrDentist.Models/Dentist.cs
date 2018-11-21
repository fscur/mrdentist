using System.Collections.Generic;

namespace MrDentist.Models
{
    public class Dentist : Person
    {
        public int ProfessionalRegister { get; set; }
        public List<Patient> Patients { get; private set; }

        public Dentist()
        {
            Patients = new List<Patient>();
        }
    }
}
