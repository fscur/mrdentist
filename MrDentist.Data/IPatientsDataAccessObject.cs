using MrDentist.Models;
using System.Collections.Generic;

namespace MrDentist.Data
{
    public interface IPatientsDataAccessObject : IDataAccessObject<Patient>
    {
        IEnumerable<Patient> GetPatientsByDentistId(int id);
    }
}