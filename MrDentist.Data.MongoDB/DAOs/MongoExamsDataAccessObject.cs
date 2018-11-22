using System.Collections.Generic;
using MrDentist.Models;

namespace MrDentist.Data.MongoDB.DAOs
{
    internal class MongoExamsDataAccessObject : IExamsDataAccessObject
    {
        private MongoDataRepository repository;

        public IEnumerable<Exam> All => new List<Exam>();

        public MongoExamsDataAccessObject(MongoDataRepository repository)
        {
            this.repository = repository;
        }

        public bool Add(Exam obj)
        {
            throw new System.NotImplementedException();
        }

        public Exam Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public bool Remove(Exam obj)
        {
            throw new System.NotImplementedException();
        }

        public bool Update(Exam obj)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Exam> GetExamsByPatientId(int id)
        {
            return new List<Exam>();
        }
    }
}