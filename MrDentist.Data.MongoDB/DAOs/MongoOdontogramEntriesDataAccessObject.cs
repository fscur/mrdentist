using System.Collections.Generic;
using MongoDB.Driver;
using MrDentist.Data.MongoDB.DTOs;
using MrDentist.Models;

namespace MrDentist.Data.MongoDB.DAOs
{
    internal class MongoOdontogramEntriesDataAccessObject : IOdontogramEntriesDataAccessObject
    {
        private readonly MongoDataRepository repository;
        private readonly IMongoCollection<MongoOdontogramEntryDTO> entriesCollection;
        private readonly IMongoCollection<MongoDentalIssueDTO> issuesCollection;

        public MongoOdontogramEntriesDataAccessObject(MongoDataRepository repository)
        {
            this.repository = repository;
            var database = repository.Client.GetDatabase(MongoDataRepository.DATABASE_NAME);
            this.entriesCollection = database.GetCollection<MongoOdontogramEntryDTO>("odontogram_entries");
            this.issuesCollection = database.GetCollection<MongoDentalIssueDTO>("dental_issues");
        }

        public IEnumerable<OdontogramEntry> All
        {   
            get
            {
                var result = entriesCollection.Find(FilterDefinition<MongoOdontogramEntryDTO>.Empty).ToList();

                foreach (var item in result)
                {
                    var odontogramEntry = item.ToObj(repository);

                    issuesCollection.Find(i => i.OdontogramEntryId == item.Id)
                    .ForEachAsync(p => odontogramEntry.DentalIssues.Add(p.ToObj(repository)));

                    yield return odontogramEntry;
                }
            }
        }
        
        public bool Add(OdontogramEntry obj)
        {
            try
            {
                foreach (var dentalIssue in obj.DentalIssues)
                {   
                    issuesCollection.InsertOne(dentalIssue.ToDto(obj.Id));
                }

                var dto = obj.ToDto();
                entriesCollection.InsertOne(dto);
            }
            catch (System.Exception)
            {
                throw;
            }

            return true;
        }

        public OdontogramEntry Get(int id)
        {
            try
            {
                var odontogramEntry = entriesCollection.Find(u => u.Id == id).SingleOrDefault()?.ToObj(repository);

                issuesCollection.Find(i => i.OdontogramEntryId == id)
                    .ForEachAsync(p => odontogramEntry.DentalIssues.Add(p.ToObj(repository)));

                return odontogramEntry;
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public IEnumerable<OdontogramEntry> GetEntriesByOdontogramId(int id)
        {
            var result = entriesCollection.Find(o => o.OdontogramId == id).ToList();
            foreach (var item in result)
            {
                var odontogramEntry = item.ToObj(repository);

                issuesCollection.Find(i => i.OdontogramEntryId == item.Id)
                    .ForEachAsync(p => odontogramEntry.DentalIssues.Add(p.ToObj(repository)));

                yield return odontogramEntry;
            }
        }

        public bool Remove(OdontogramEntry obj)
        {
            throw new System.NotImplementedException();
        }

        public bool Update(OdontogramEntry obj)
        {
            throw new System.NotImplementedException();
        }
    }
}