using System.Collections.Generic;
using MrDentist.Models;
using MongoDB.Driver;

namespace MrDentist.Data.MongoDB
{
    public class MongoPatientsDataAccessObject : IDataAccessObject<Patient>
    {
        private string connectionString;
        private string databaseName;
        private string collectionName;

        private MongoClient client;
        private IMongoDatabase database;
        private IMongoCollection<MongoPatientDTO> collection;

        public MongoPatientsDataAccessObject(string connectionString, string databaseName, string collectionName)
        {
            this.connectionString = connectionString;
            this.databaseName = databaseName;
            this.collectionName = collectionName;

            client = new MongoClient(connectionString);
            database = client.GetDatabase(databaseName);
            collection = database.GetCollection<MongoPatientDTO>(collectionName);
         }

        public IEnumerable<Patient> All {
            get {
                var result = collection.Find(FilterDefinition<MongoPatientDTO>.Empty).ToList();
                foreach (var item in result)
                {
                    yield return item.ToObj();
                }
            }
        }

        public bool Add(Patient obj)
        {
            try
            {
                var dto = obj.ToDto();
                collection.InsertOne(dto);
            }
            catch (System.Exception ex)
            {
                throw;
            }

            return true;
        }

        public Patient Get(int id)
        {
            throw new System.NotImplementedException();
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