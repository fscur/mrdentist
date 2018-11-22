using MrDentist.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrDentist.Data.Memory
{
    public class PatientsDataAccessObject : IPatientsDataAccessObject
    {
        private List<Patient> patients;

        public PatientsDataAccessObject()
        {
            patients = new List<Patient>();
        }

        public bool Add(Patient obj)
        {
            patients.Add(obj);
            return true;
        }

        public Patient Get(int id)
        {
            return patients.Find(p => p.Id == id);
        }

        public bool Remove(Patient obj)
        {
            patients.Remove(obj);
            return true;
        }

        public bool Update(Patient obj)
        {
            return true;
        }

        public IEnumerable<Patient> GetPatientsByDentistId(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Patient> All => patients;
    }
}
