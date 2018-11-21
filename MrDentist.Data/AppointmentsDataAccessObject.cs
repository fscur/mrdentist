using MrDentist.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrDentist.Data
{
    public class AppointmentsDataAccessObject : IAppointmentsDataAccessObject
    {
        private List<Appointment> appointments;

        public IEnumerable<Appointment> All => appointments;

        public AppointmentsDataAccessObject()
        {
            appointments = new List<Appointment>();
        }

        public bool Add(Appointment obj)
        {
            appointments.Add(obj);
            return true;
        }

        public Appointment Get(int id)
        {
            return appointments.Find(a => a.Id == id);
        }

        public bool Remove(Appointment obj)
        {
            appointments.Remove(obj);
            return true;
        }

        public bool Update(Appointment obj)
        {
            return true;
        }

        public IEnumerable<Appointment> GetByPatientAndDentist(Patient patient, Dentist dentist)
        {
            return appointments.Where(a => a.Dentist.Id == dentist.Id && a.Patient.Id == patient.Id);
        }
    }
}
