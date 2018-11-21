using MrDentist.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrDentist.Data
{
    public interface IAppointmentsDataAccessObject : IDataAccessObject<Appointment>
    {
        IEnumerable<Appointment> GetByPatientAndDentist(Patient patient, Dentist dentist);
    }
}
