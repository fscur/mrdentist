using MrDentist.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrDentist.Data.DTOs
{
    public interface IAppointmentDTO
    {
        int Id { get; set; }
        DateTime Date { get; set; }
        int PatientId { get; set; }
        int DentistId { get; set; }
        string Observations { get; set; }
        bool Attended { get; set; }
        int? OdontogramEntryId { get; set; }
    }
}
