using MongoDB.Driver;
using MrDentist.Data.MongoDB.DAOs;
using System;

namespace MrDentist.Data.MongoDB
{
    public class MongoDataRepository : IDataRepository
    {
        internal const string DATABASE_NAME = "mrdentist";

        private readonly MongoPatientsDataAccessObject patients;
        private readonly MongoDentistsDataAccessObject dentists;
        private readonly MongoAppointmentsDataAccessObject appointments;
        private readonly MongoExamsDataAccessObject exams;
        private readonly MongoPicturesDataAccessObject pictures;
        private readonly MongoOdontogramDataAccessObject odontograms;
        private readonly MongoAddressesDataAccessObject addresses;
        private readonly MongoUsersDataAccessObjects users;

        public IPatientsDataAccessObject Patients => patients;
        public IDentistsDataAccessObject Dentists => dentists;
        public IAppointmentsDataAccessObject Appointments => appointments;
        public IExamsDataAccessObject Exams => exams;
        public IPicturesDataAccessObject Pictures => pictures;
        public IOdontogramsDataAccessObject Odontograms => odontograms;
        public IAddressesDataAccessObject Addresses => addresses;
        public IUsersDataAccessObject Users => users;

        internal MongoClient Client { get; private set; }

        public MongoDataRepository(string connectionString)
        {
            Client = new MongoClient(connectionString);
            this.patients = new MongoPatientsDataAccessObject(this);
            this.dentists = new MongoDentistsDataAccessObject(this);
            this.appointments = new MongoAppointmentsDataAccessObject(this);
            this.exams = new MongoExamsDataAccessObject(this);
            this.pictures = new MongoPicturesDataAccessObject(this);
            this.odontograms = new MongoOdontogramDataAccessObject(this);
            this.addresses = new MongoAddressesDataAccessObject(this);
            this.users = new MongoUsersDataAccessObjects(this);
        }
    }
}
