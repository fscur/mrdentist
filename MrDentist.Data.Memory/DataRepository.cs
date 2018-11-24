using System;

namespace MrDentist.Data.Memory
{
    public class DataRepository : IDataRepository
    {
        private PatientsDataAccessObject patients;
        private DentistsDataAccessObject dentists;
        private AppointmentsDataAccessObject appointments;
        private OdontogramsDataAccessObject odontograms;
        private ExamsDataAccessObject exams;
        private PicturesDataAccessObject pictures;
        private AddressesDataAccessObject addresses;
        private UsersDataAccessObject users;


        public IPatientsDataAccessObject Patients => patients;
        public IDentistsDataAccessObject Dentists => dentists;
        public IAppointmentsDataAccessObject Appointments => appointments;
        public IOdontogramsDataAccessObject Odontograms => odontograms;
        public IExamsDataAccessObject Exams => exams;
        public IPicturesDataAccessObject Pictures => pictures;
        public IAddressesDataAccessObject Addresses => addresses;
        public IUsersDataAccessObject Users => users;

        public IOdontogramEntriesDataAccessObject OdontogramEntries => throw new NotImplementedException();

        public DataRepository()
        {
            patients = new PatientsDataAccessObject();
            dentists = new DentistsDataAccessObject();
            appointments = new AppointmentsDataAccessObject();
            odontograms = new OdontogramsDataAccessObject();
            exams = new ExamsDataAccessObject();
            pictures = new PicturesDataAccessObject();
            addresses = new AddressesDataAccessObject();
            users = new UsersDataAccessObject();
        }
    }
}
