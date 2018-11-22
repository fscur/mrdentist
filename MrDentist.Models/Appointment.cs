using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrDentist.Models
{
    public class Appointment
    {
        public int Id { get; private set; }
        public DateTime Date { get; set; }
        public Patient Patient { get; set; }
        public Dentist Dentist { get; set; }
        public string Observations { get; set; }
        public bool Attended { get; set; }
        public OdontogramEntry OdontogramEntry { get; set; }

        public Appointment(int id)
        {
            Id = id;
        }
    }
}
