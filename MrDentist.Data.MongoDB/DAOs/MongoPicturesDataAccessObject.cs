using System.Collections.Generic;
using MrDentist.Models;

namespace MrDentist.Data.MongoDB.DAOs
{
    internal class MongoPicturesDataAccessObject : IPicturesDataAccessObject
    {
        private MongoDataRepository repository;

        public IEnumerable<Picture> All => throw new System.NotImplementedException();

        public MongoPicturesDataAccessObject(MongoDataRepository repository)
        {
            this.repository = repository;
        }

        public bool Add(Picture obj)
        {
            throw new System.NotImplementedException();
        }

        public Picture Get(int id)
        {
            return null;
        }

        public bool Remove(Picture obj)
        {
            throw new System.NotImplementedException();
        }

        public bool Update(Picture obj)
        {
            throw new System.NotImplementedException();
        }
    }
}