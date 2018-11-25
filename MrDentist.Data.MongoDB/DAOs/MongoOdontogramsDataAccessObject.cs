using System;
using System.Collections.Generic;
using System.Linq;
using MongoDB.Driver;
using MrDentist.Data.MongoDB.DTOs;
using MrDentist.Models;

namespace MrDentist.Data.MongoDB.DAOs
{
    internal class MongoOdontogramsDataAccessObject : IOdontogramsDataAccessObject
    {
        private readonly MongoDataRepository repository;
        private readonly IMongoCollection<MongoOdontogramDTO> odontogramsCollection;
        private readonly IMongoCollection<MongoOdontogramEntryDTO> entriesCollection;
        private readonly IMongoCollection<MongoDentalIssueDTO> issuesCollection;
        private readonly IMongoCollection<MongoPatientDTO> patientsCollection;

        public MongoOdontogramsDataAccessObject(MongoDataRepository repository)
        {
            this.repository = repository;
            var database = repository.Client.GetDatabase(MongoDataRepository.DATABASE_NAME);
            this.odontogramsCollection = database.GetCollection<MongoOdontogramDTO>("odontograms");
            this.entriesCollection = database.GetCollection<MongoOdontogramEntryDTO>("odontogram_entries");
            this.issuesCollection = database.GetCollection<MongoDentalIssueDTO>("dental_issues");
            this.patientsCollection = database.GetCollection<MongoPatientDTO>("patients");
        }

        private IEnumerable<OdontogramEntry> GetOdontogramEntries(int id)
        {
            var result = entriesCollection.Find(i=>i.OdontogramId == id).ToList();

            foreach (var item in result)
            {
                var odontogramEntry = item.ToObj(repository);

                var issues = issuesCollection.Find(i => i.OdontogramEntryId == item.Id).ToList();
                
                foreach (var issue in issues)
                {
                    odontogramEntry.DentalIssues.Add(issue.ToObj(repository));
                }

                yield return odontogramEntry;
            }
        }

        public IEnumerable<Odontogram> All
        {
            get
            {
                var result = odontogramsCollection.Find(FilterDefinition<MongoOdontogramDTO>.Empty).ToList();
                foreach (var item in result)
                {
                    var odontogram = item.ToObj(repository);
                    odontogram.Entries.AddRange(GetOdontogramEntries(item.Id));
                    yield return odontogram;
                }
            }
        }
        
        private void AddOdontogramEntries(Odontogram obj)
        {
            foreach (var odontogramEntry in obj.Entries)
            {
                entriesCollection.InsertOne(odontogramEntry.ToDto(obj.Id));

                foreach (var dentalIssue in odontogramEntry.DentalIssues)
                {
                    issuesCollection.InsertOne(dentalIssue.ToDto(odontogramEntry.Id));
                }
            }
        }

        public bool Add(Odontogram obj)
        {
            try
            {
                AddOdontogramEntries(obj);

                var dto = obj.ToDto();
                odontogramsCollection.InsertOne(dto);
            }
            catch (System.Exception)
            {
                throw;
            }

            return true;
        }

        public Odontogram Get(int id)
        {
            try
            {
                var odontogram = odontogramsCollection.Find(u => u.Id == id).SingleOrDefault()?.ToObj(repository);
                if (odontogram!= null)
                    odontogram.Entries.AddRange(GetOdontogramEntries(id));

                return odontogram;
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }

        public bool Remove(Odontogram obj)
        {
            throw new System.NotImplementedException();
        }

        public bool Update(Odontogram obj)
        {
            throw new System.NotImplementedException();
        }

        public OdontogramEntry GetOdontogramEntry(int odontogramId, DateTime date)
        {
            try
            {
                var entries = GetOdontogramEntries(odontogramId);

                return entries.FirstOrDefault(e=>e.Date == date);
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }

        public void AddOdontogramEntryIssue(int entryId, IDentalIssue issue)
        {
            issuesCollection.InsertOne(issue.ToDto(entryId));
        }

        public int GetNextIssueId()
        {
            var id = issuesCollection.Find(FilterDefinition<MongoDentalIssueDTO>.Empty).SortByDescending(p => p.Id).FirstOrDefault()?.Id;
            return id.HasValue ? id.Value + 1 : 0;
        }
    }
}