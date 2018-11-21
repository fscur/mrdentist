using MrDentist.Models;
using System.Collections.Generic;
using System.Linq;

namespace MrDentist.Data.MongoDB
{
    public class MongoPatientDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? AddressId { get; set; }
        public List<string> Phones { get; set; }
        public int? UserId { get; set; }
        public string PictureUrl { get; set; }
        public string InsuranceNumber { get; set; }
        public string BloodType { get; set; }
        public int? OdontogramId { get; set; }
        public int DentistId { get; set; }
        public List<int?> ExamsIds { get; set; }
    }

    public static partial class PatientExtensions
    {
        public static MongoPatientDTO ToDto(this Patient patient)
        {
            return new MongoPatientDTO()
            {
                Id = patient.Id,
                Name = patient.Name,
                InsuranceNumber = patient.InsuranceNumber,
                Phones = patient.Phones,
                BloodType = patient.BloodType,
                ExamsIds = patient.Exams.Select(e => e?.Id).ToList(),
                PictureUrl = "getpictureurlsomewhere",
                AddressId = patient.Address.Id,
                DentistId = patient.Dentist.Id,
                OdontogramId = patient.Odontogram?.Id,
                UserId = patient.User?.Id
            };
        }

        public static Patient ToObj(this MongoPatientDTO dto)
        {
            return new Patient()
            {
                Id = dto.Id,
                Name = dto.Name,
                InsuranceNumber = dto.InsuranceNumber,
                Phones = new List<string>(),
                BloodType = dto.BloodType,
                Exams = new List<Exam>(),
                Picture = null,
                Address = null,
                Dentist = null,
                Odontogram = null,
                User = null
            };
        }
    }
}