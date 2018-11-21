using MrDentist.Models;
using System.Collections.Generic;

namespace MrDentist.Data.MongoDB
{
    internal class MongoAppointmentsDataAccessObject : IAppointmentsDataAccessObject
    {
        public IEnumerable<Appointment> All => throw new System.NotImplementedException();

        public bool Add(Appointment obj)
        {
            throw new System.NotImplementedException();
        }

        public Appointment Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Appointment> GetByPatientAndDentist(Patient patient, Dentist dentist)
        {
            throw new System.NotImplementedException();
        }

        public bool Remove(Appointment obj)
        {
            throw new System.NotImplementedException();
        }

        public bool Update(Appointment obj)
        {
            throw new System.NotImplementedException();
        }
    }
}