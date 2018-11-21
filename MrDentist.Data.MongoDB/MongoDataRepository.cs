using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MrDentist.Models;

namespace MrDentist.Data.MongoDB
{
    public class MongoDataRepository : IDataRepository
    {
        private MongoPatientsDataAccessObject _patients;
        private MongoDentistsDataAccessObject _dentists;
        private MongoAppointmentsDataAccessObject _appointments;

        public IDataAccessObject<Patient> Patients => _patients;
        public IDataAccessObject<Dentist> Dentists => _dentists;
        public IDataAccessObject<Appointment> Appointments => _appointments;

        public MongoDataRepository(string connectionString)
        {
            _patients = new MongoPatientsDataAccessObject(connectionString, "mrdentist", "patients");
        }
    }
}
