using System.Collections.Generic;
using MrDentist.Models;

namespace MrDentist.Data.MongoDB
{
    internal class MongoDentistsDataAccessObject : IDataAccessObject<Dentist>
    {
        public IEnumerable<Dentist> All => throw new System.NotImplementedException();

        public bool Add(Dentist obj)
        {
            throw new System.NotImplementedException();
        }

        public Dentist Get(int id)
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