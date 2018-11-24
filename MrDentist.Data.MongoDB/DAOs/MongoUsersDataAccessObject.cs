using System.Collections.Generic;
using MongoDB.Driver;
using MrDentist.Data.MongoDB.DTOs;
using MrDentist.Models;

namespace MrDentist.Data.MongoDB.DAOs
{
    internal class MongoUsersDataAccessObject : IUsersDataAccessObject
    {
        private readonly MongoDataRepository repository;
        private readonly IMongoCollection<MongoUserDTO> collection;

        public MongoUsersDataAccessObject(MongoDataRepository repository)
        {
            this.repository = repository;
            var database = repository.Client.GetDatabase(MongoDataRepository.DATABASE_NAME);
            this.collection = database.GetCollection<MongoUserDTO>("users");
        }

        public IEnumerable<User> All
        {
            get
            {
                var result = collection.Find(FilterDefinition<MongoUserDTO>.Empty).ToList();
                foreach (var item in result)
                {
                    yield return item.ToObj(repository);
                }
            }
        }

        public bool Add(User obj)
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

        public User Get(int id)
        {
            try
            {
                return collection.Find(u => u.Id == id).SingleOrDefault()?.ToObj(repository);
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public bool Remove(User obj)
        {
            throw new System.NotImplementedException();
        }

        public bool Update(User obj)
        {
            throw new System.NotImplementedException();
        }
    }
}