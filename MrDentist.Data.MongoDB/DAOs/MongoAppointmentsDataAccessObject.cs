using MongoDB.Driver;
using MrDentist.Data.MongoDB.DTOs;
using MrDentist.Models;
using System.Collections.Generic;

namespace MrDentist.Data.MongoDB.DAOs
{
    internal class MongoAppointmentsDataAccessObject : IAppointmentsDataAccessObject
    {
        private readonly MongoDataRepository repository;
        private readonly IMongoCollection<MongoAppointmentDTO> collection;

        public MongoAppointmentsDataAccessObject(MongoDataRepository repository)
        {
            this.repository = repository;
            var database = repository.Client.GetDatabase(MongoDataRepository.DATABASE_NAME);
            this.collection = database.GetCollection<MongoAppointmentDTO>("appointments");
        }

        public IEnumerable<Appointment> All
        {
            get
            {
                var result = collection.Find(FilterDefinition<MongoAppointmentDTO>.Empty).ToList();
                foreach (var item in result)
                {
                    yield return item.ToObj(repository);
                }
            }
        }

        public bool Add(Appointment obj)
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

        public Appointment Get(int id)
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

        public IEnumerable<Appointment> GetByPatientAndDentist(Patient patient, Dentist dentist)
        {
            var result = collection.Find(a=>a.PatientId == patient.Id && a.DentistId == dentist.Id).ToList();
            foreach (var item in result)
            {
                yield return item.ToObj(repository);
            }
        }

        public bool Remove(Appointment obj)
        {
            throw new System.NotImplementedException();
        }

        public bool Update(Appointment obj)
        {
            throw new System.NotImplementedException();
        }
    }
}