using MongoDB.Driver;
using MrDentist.Data.MongoDB.DAOs;
using System;
using System.Collections.Generic;
using System.Security.Authentication;

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
        private readonly MongoOdontogramsDataAccessObject odontograms;
        //private readonly MongoOdontogramEntriesDataAccessObject odontogramEntries;
        private readonly MongoAddressesDataAccessObject addresses;
        private readonly MongoUsersDataAccessObject users;

        public IPatientsDataAccessObject Patients => patients;
        public IDentistsDataAccessObject Dentists => dentists;
        public IAppointmentsDataAccessObject Appointments => appointments;
        public IExamsDataAccessObject Exams => exams;
        public IPicturesDataAccessObject Pictures => pictures;
        public IOdontogramsDataAccessObject Odontograms => odontograms;
        //public IOdontogramEntriesDataAccessObject OdontogramEntries => odontogramEntries;
        public IAddressesDataAccessObject Addresses => addresses;
        public IUsersDataAccessObject Users => users;

        internal MongoClient Client { get; private set; }

        public MongoDataRepository(string connectionString)
        {
            MongoClientSettings settings = new MongoClientSettings();
            settings.Server = new MongoServerAddress("mrdentist.documents.azure.com", 10255);
            settings.UseSsl = true;
            settings.SslSettings = new SslSettings();
            settings.SslSettings.EnabledSslProtocols = SslProtocols.Tls12;

            MongoIdentity identity = new MongoInternalIdentity("mrdentist", "mrdentist");
            MongoIdentityEvidence evidence = new PasswordEvidence("R5oUrEPPRLrzt4kRk4hXwsdMEqpJsyXwsSFmkrq38zumTjd4I2SaeYktBC8J2chAOiVhiP9SbFEXKMNXXXn6jA==");

            settings.Credential = new MongoCredential("SCRAM-SHA-1", identity, evidence);


            Client = new MongoClient(connectionString);
            this.patients = new MongoPatientsDataAccessObject(this);
            this.dentists = new MongoDentistsDataAccessObject(this);
            this.appointments = new MongoAppointmentsDataAccessObject(this);
            this.exams = new MongoExamsDataAccessObject(this);
            this.pictures = new MongoPicturesDataAccessObject(this);
            this.odontograms = new MongoOdontogramsDataAccessObject(this);
            //this.odontogramEntries = new MongoOdontogramEntriesDataAccessObject(this);
            this.addresses = new MongoAddressesDataAccessObject(this);
            this.users = new MongoUsersDataAccessObject(this);
        }
    }
}
