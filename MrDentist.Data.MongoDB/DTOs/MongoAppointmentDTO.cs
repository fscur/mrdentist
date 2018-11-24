using MrDentist.Models;
using System;

namespace MrDentist.Data.MongoDB
{
    internal class MongoAppointmentDTO
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int PatientId { get; set; }
        public int DentistId { get; set; }
        public string Observations { get; set; }
        public bool Attended { get; set; }
        public int? OdontogramEntryId { get; set; }
    }

    internal static partial class AppointmentExtensions
    {
        public static MongoAppointmentDTO ToDto(this Appointment obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }

            return new MongoAppointmentDTO()
            {
                Id = obj.Id,
                Date = obj.Date,
                PatientId = obj.Patient.Id,
                DentistId = obj.Dentist.Id,
                Observations = obj.Observations,
                Attended = obj.Attended,
                OdontogramEntryId = obj.OdontogramEntry?.Id
            };
        }

        public static Appointment ToObj(this MongoAppointmentDTO dto, IDataRepository repository)
        {
            if (dto == null)
            {
                throw new System.ArgumentNullException(nameof(dto));
            }

            if (repository == null)
            {
                throw new System.ArgumentNullException(nameof(repository));
            }

            var patient = repository.Patients.Get(dto.PatientId);
            var odontogramEntry = repository.Odontograms.GetOdontogramEntry(patient.Id, dto.Date);
            return new Appointment(dto.Id)
            {
                Attended = dto.Attended,
                Date = dto.Date,
                Observations = dto.Observations,
                Dentist = repository.Dentists.Get(dto.DentistId),
                Patient = repository.Patients.Get(dto.PatientId),
                OdontogramEntry = odontogramEntry
            };  
        }
    }
}