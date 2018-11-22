using System.Collections.Generic;
using MrDentist.Models;

namespace MrDentist.Data.Memory
{
    public class OdontogramsDataAccessObject : IOdontogramsDataAccessObject
    {
        public OdontogramsDataAccessObject()
        {
        }

        public IEnumerable<Odontogram> All => throw new System.NotImplementedException();

        public bool Add(Odontogram obj)
        {
            throw new System.NotImplementedException();
        }

        public Odontogram Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public Odontogram GetByPatientId(int id)
        {
            throw new System.NotImplementedException();
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