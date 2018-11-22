using MrDentist.Models;
using System.Collections.Generic;
using System.Linq;

namespace MrDentist.Data.MongoDB.DTOs
{
    public class MongoPatientDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? AddressId { get; set; }
        public List<string> Phones { get; set; }
        public int? UserId { get; set; }
        public int? PictureId { get; set; }
        public string InsuranceNumber { get; set; }
        public string BloodType { get; set; }
        public int? OdontogramId { get; set; }
        public int DentistId { get; set; }
        public List<int?> ExamsIds { get; set; }
    }

    public static partial class PatientExtensions
    {
        public static MongoPatientDTO ToDto(this Patient obj)
        {
            if (obj == null)
            {
                throw new System.ArgumentNullException(nameof(obj));
            }

            return new MongoPatientDTO()
            {
                Id = obj.Id,
                Name = obj.Name,
                InsuranceNumber = obj.InsuranceNumber,
                Phones = obj.Phones,
                BloodType = obj.BloodType,
                ExamsIds = obj.Exams.Select(e => e?.Id).ToList(),
                PictureId = obj.Picture?.Id,
                AddressId = obj.Address?.Id,
                DentistId = obj.Dentist.Id,
                OdontogramId = obj.Odontogram?.Id,
                UserId = obj.User?.Id
            };
        }

        public static Patient ToObj(this MongoPatientDTO dto, IDataRepository repository)
        {
            if (dto == null)
            {
                throw new System.ArgumentNullException(nameof(dto));
            }

            if (repository == null)
            {
                throw new System.ArgumentNullException(nameof(repository));
            }

            var exams = repository.Exams.GetExamsByPatientId(dto.Id).ToList();
            var dentist = repository.Dentists.Get(dto.DentistId);

            var address = dto.AddressId == null ? null : repository.Addresses.Get(dto.AddressId.Value);
            var picture = dto.PictureId == null ? null : repository.Pictures.Get(dto.PictureId.Value);
            var odontogram = dto.OdontogramId == null ? null : repository.Odontograms.Get(dto.OdontogramId.Value);
            var user = dto.UserId == null ? null : repository.Users.Get(dto.UserId.Value);

            var patient = new Patient(dto.Id)
            {
                Name = dto.Name,
                InsuranceNumber = dto.InsuranceNumber,
                Phones = dto.Phones,
                BloodType = dto.BloodType,
                Picture = picture,
                Address = address,
                Dentist = dentist,
                Odontogram = odontogram,
                User = user
            };

            patient.Exams.AddRange(exams);

            return patient;
        }
    }
}