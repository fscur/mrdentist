using System.Collections.Generic;
using MrDentist.Models;

namespace MrDentist.Data.MongoDB.DAOs
{
    internal class MongoOdontogramDataAccessObject : IOdontogramsDataAccessObject
    {
        private readonly MongoDataRepository repository;

        public MongoOdontogramDataAccessObject(MongoDataRepository repository)
        {
            this.repository = repository;
        }

        public IEnumerable<Odontogram> All => throw new System.NotImplementedException();

        public bool Add(Odontogram obj)
        {
            throw new System.NotImplementedException();
        }

        public Odontogram Get(int id)
        {
            return new Odontogram(0)
            {
                BaseImage = null
            };
        }

        public Odontogram GetByPatientId(int id)
        {
            return new Odontogram(0)
            {
                BaseImage = null
            };
        }

        public bool Remove(Odontogram obj)
        {
            throw new System.NotImplementedException();
        }

        public bool Update(Odontogram obj)
        {
            throw new System.NotImplementedException();
        }
    }
}