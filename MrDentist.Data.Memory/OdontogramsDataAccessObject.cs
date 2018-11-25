using System;
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

        public void AddOdontogramEntryIssue(int entryId, IDentalIssue issue)
        {
            throw new NotImplementedException();
        }

        public Odontogram Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public Odontogram GetByPatientId(int id)
        {
            throw new System.NotImplementedException();
        }

        public int GetNextIssueId()
        {
            throw new NotImplementedException();
        }

        public OdontogramEntry GetOdontogramEntry(int odontogramId, DateTime date)
        {
            throw new NotImplementedException();
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