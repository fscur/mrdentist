using System.Collections.Generic;
using MongoDB.Driver;
using MrDentist.Data.MongoDB.DTOs;
using MrDentist.Models;

namespace MrDentist.Data.MongoDB.DAOs
{
    internal class MongoDentistsDataAccessObject : IDentistsDataAccessObject
    {
        private readonly MongoDataRepository repository;
        private readonly IMongoCollection<MongoDentistDTO> collection;

        public MongoDentistsDataAccessObject(MongoDataRepository repository)
        {
            this.repository = repository;
            var database = repository.Client.GetDatabase(MongoDataRepository.DATABASE_NAME);
            this.collection = database.GetCollection<MongoDentistDTO>("dentists");
        }

        public IEnumerable<Dentist> All
        {
            get
            {
                var result = collection.Find(FilterDefinition<MongoDentistDTO>.Empty).ToList();
                foreach (var item in result)
                {
                    yield return item.ToObj(repository);
                }
            }
        }

        public bool Add(Dentist obj)
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

        public Dentist Get(int id)
        {
            return collection.Find(p => p.Id == id).FirstOrDefault()?.ToObj(repository);
        }

        public Dentist GetByUser(User user)
        {
            throw new System.NotImplementedException();
        }

        public bool Remove(Dentist obj)
        {
            throw new System.NotImplementedException();
        }

        public bool Update(Dentist obj)
        {
            throw new System.NotImplementedException();
        }
    }
}