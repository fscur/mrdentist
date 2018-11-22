using MrDentist.Models;
using System.Collections.Generic;

namespace MrDentist.Data
{
    public interface IExamsDataAccessObject : IDataAccessObject<Exam>
    {
        IEnumerable<Exam> GetExamsByPatientId(int id);
    }
}