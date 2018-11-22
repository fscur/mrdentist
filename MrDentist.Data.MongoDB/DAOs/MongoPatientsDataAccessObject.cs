using System.Collections.Generic;
using MrDentist.Models;
using MongoDB.Driver;
using MrDentist.Data.MongoDB.DTOs;

namespace MrDentist.Data.MongoDB.DAOs
{
    public class MongoPatientsDataAccessObject : IPatientsDataAccessObject
    {
        private readonly MongoDataRepository repository;
        private readonly IMongoCollection<MongoPatientDTO> collection;

        public MongoPatientsDataAccessObject(MongoDataRepository repository)
        {
            this.repository = repository;
            var database = repository.Client.GetDatabase(MongoDataRepository.DATABASE_NAME);
            collection = database.GetCollection<MongoPatientDTO>("patients");
        }

        public IEnumerable<Patient> All
        {
            get
            {
                var result = collection.Find(FilterDefinition<MongoPatientDTO>.Empty).ToList();

                foreach (var item in result)
                    yield return item.ToObj(repository);
            }
        }

        public bool Add(Patient obj)
        {
            try
            {
                var dto = obj.ToDto();
                collection.InsertOne(dto);
            }
            catch (System.Exception)
            {
                return false;
            }

            return true;
        }

        public Patient Get(int id)
        {
            return collection.Find(p => p.Id == id).FirstOrDefault()?.ToObj(repository);
        }

        public IEnumerable<Patient> GetPatientsByDentistId(int id)
        {
            var result = collection.Find(p=>p.DentistId == id).ToEnumerable();

            foreach (var item in result)
            {
                yield return item.ToObj(repository);
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