using System.Collections.Generic;
using MrDentist.Models;
using MongoDB.Driver;
using MrDentist.Data.MongoDB.DTOs;

namespace MrDentist.Data.MongoDB.DAOs
{
    public class MongoPatientsDataAccessObject : IPatientsDataAccessObject
    {
        private readonly MongoDataRepository repository;
        private readonly IMongoCollection<MongoPatientDTO> patientsCollection;

        public MongoPatientsDataAccessObject(MongoDataRepository repository)
        {
            this.repository = repository;
            var database = repository.Client.GetDatabase(MongoDataRepository.DATABASE_NAME);
            patientsCollection = database.GetCollection<MongoPatientDTO>("patients");
        }

        public IEnumerable<Patient> All
        {
            get
            {
                var result = patientsCollection.Find(FilterDefinition<MongoPatientDTO>.Empty).ToList();

                foreach (var item in result)
                {
                    var patient = item.ToObj(repository);

                    if (item.OdontogramId.HasValue)
                        patient.Odontogram = repository.Odontograms.Get(item.OdontogramId.Value);

                    yield return patient;
                }
            }
        }

        public bool Add(Patient obj)
        {
            try
            {
                var dto = obj.ToDto();
                patientsCollection.InsertOne(dto);
            }
            catch (System.Exception)
            {
                return false;
            }

            return true;
        }

        public Patient Get(int id)
        {
            var dto = patientsCollection.Find(p => p.Id == id).FirstOrDefault();
            var patient = dto?.ToObj(repository);

            if (dto == null)
                return null;

            if (dto.OdontogramId.HasValue)
                patient.Odontogram = repository.Odontograms.Get(dto.OdontogramId.Value);

            return patient;
        }

        public IEnumerable<Patient> GetPatientsByDentistId(int id)
        {
            var result = patientsCollection.Find(p=>p.DentistId == id).ToEnumerable();

            foreach (var item in result)
            {
                var patient = item.ToObj(repository);

                if (item.OdontogramId.HasValue)
                    patient.Odontogram = repository.Odontograms.Get(item.OdontogramId.Value);

                yield return patient;
            }
        }

        public bool Remove(Patient obj)
        {
            throw new System.NotImplementedException();
        }

        public bool Update(Patient obj)
        {
            throw new System.NotImplementedException();
        }
    }
}