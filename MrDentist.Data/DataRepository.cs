using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MrDentist.Models;

namespace MrDentist.Data
{
    public class DataRepository : IDataRepository
    {
        private PatientsDataAccessObject _patients;
        private DentistsDataAccessObject _dentists;
        private AppointmentsDataAccessObject _appointments;

        public IDataAccessObject<Patient> Patients => _patients;
        public IDataAccessObject<Dentist> Dentists => _dentists;
        public IDataAccessObject<Appointment> Appointments => _appointments;

        public DataRepository()
        {
            _patients = new PatientsDataAccessObject();
            _dentists = new DentistsDataAccessObject();
            _appointments = new AppointmentsDataAccessObject();
        }
    }
}
