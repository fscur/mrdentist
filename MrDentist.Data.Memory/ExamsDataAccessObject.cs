using System.Collections.Generic;
using MrDentist.Models;

namespace MrDentist.Data.Memory
{
    internal class ExamsDataAccessObject : IExamsDataAccessObject
    {
        public IEnumerable<Exam> All => throw new System.NotImplementedException();

        public bool Add(Exam obj)
        {
            throw new System.NotImplementedException();
        }

        public Exam Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Exam> GetExamsByPatientId(int id)
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
    }
}