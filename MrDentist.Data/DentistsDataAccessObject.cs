using MrDentist.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrDentist.Data
{
    public class DentistsDataAccessObject : IDataAccessObject<Dentist>
    {
        private List<Dentist> dentists;

        public DentistsDataAccessObject()
        {
            dentists = new List<Dentist>();
        }

        public bool Add(Dentist obj)
        {
            dentists.Add(obj);
            return true;
        }

        public Dentist Get(int id)
        {
            return dentists.Find(p => p.Id == id);
        }

        public bool Remove(Dentist obj)
        {
            dentists.Remove(obj);
            return true;
        }

        public bool Update(Dentist obj)
        {
            return true;
        }

        public IEnumerable<Dentist> All => dentists;

        public Dentist GetByUser(User user)
        {
            return dentists.FirstOrDefault(d => d.User == user);
        }
    }
}
