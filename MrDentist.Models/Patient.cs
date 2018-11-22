using System;
using System.Collections.Generic;
using System.Drawing;

namespace MrDentist.Models
{
    public class Patient : Person
    {
        public string InsuranceNumber { get; set; }
        public string BloodType { get; set; }
        public Picture Picture { get; set; }
        public List<Exam> Exams { get; private set; }
        public Odontogram Odontogram { get; set; }
        public Dentist Dentist { get; set; }

        public Patient(int id) : base(id)
        {
            Exams = new List<Exam>();
        }
    }
}
