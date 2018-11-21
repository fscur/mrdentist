using System;
using System.Collections.Generic;
using System.Drawing;

namespace MrDentist.Models
{
    public class Patient : Person
    {
        public Image Picture { get; set; }
        public string InsuranceNumber { get; set; }
        public string BloodType { get; set; }
        public List<Exam> Exams { get; set; }
        public Odontogram Odontogram { get; set; }
        public Dentist Dentist { get; set; }
    }
}
