using System.Collections.Generic;
using MongoDB.Driver;
using MrDentist.Data.MongoDB.DTOs;
using MrDentist.Models;

namespace MrDentist.Data.MongoDB.DAOs
{
    internal class MongoAddressesDataAccessObject : IAddressesDataAccessObject
    {
        private readonly MongoDataRepository repository;
        private readonly IMongoCollection<MongoAddressDTO> collection;

        public MongoAddressesDataAccessObject(MongoDataRepository repository)
        {
            this.repository = repository;
            var database = repository.Client.GetDatabase(MongoDataRepository.DATABASE_NAME);
            this.collection = database.GetCollection<MongoAddressDTO>("addresses");
        }

        public IEnumerable<Address> All
        {
            get
            {
                var result = collection.Find(FilterDefinition<MongoAddressDTO>.Empty).ToList();
                foreach (var item in result)
                {
                    yield return item.ToObj(repository);
                }
            }
        }

        public bool Add(Address obj)
        {
            try
            {
                var dto = obj.ToDto();
                collection.InsertOne(dto);
            }
            catch (System.Exception)
            {
                throw;
            }

            return true;
        }

        public Address Get(int id)
        {
            try
            {
                return collection.Find(u => u.Id == id).FirstOrDefault()?.ToObj(repository);
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public bool Remove(Address obj)
        {
            throw new System.NotImplementedException();
        }

        public bool Update(Address obj)
        {
            throw new System.NotImplementedException();
        }
    }
}