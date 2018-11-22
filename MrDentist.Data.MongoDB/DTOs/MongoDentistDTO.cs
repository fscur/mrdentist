using MrDentist.Models;
using System.Collections.Generic;

namespace MrDentist.Data.MongoDB.DTOs
{
    internal class MongoDentistDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? AddressId { get; set; }
        public List<string> Phones { get; set; }
        public int? UserId { get; set; }
        public string ProfessionalRegister { get; set; }
    }

    internal static partial class DentistExtensions
    {
        public static MongoDentistDTO ToDto(this Dentist obj)
        {
            if (obj == null)
            {
                throw new System.ArgumentNullException(nameof(obj));
            }

            return new MongoDentistDTO()
            {
                Id = obj.Id,
                Name = obj.Name,
                ProfessionalRegister = obj.ProfessionalRegister,
                Phones = obj.Phones,
                AddressId = obj.Address.Id,
                UserId = obj.User?.Id
            };
        }

        public static Dentist ToObj(this MongoDentistDTO dto, IDataRepository repository)
        {
            if (dto == null)
            {
                throw new System.ArgumentNullException(nameof(dto));
            }

            if (repository == null)
            {
                throw new System.ArgumentNullException(nameof(repository));
            }

            var patients = repository.Patients.GetPatientsByDentistId(dto.Id);
            var address = repository.Addresses.Get(dto.AddressId.Value);
            var user = repository.Users.Get(dto.UserId.Value);

            var dentist = new Dentist(dto.Id)
            {
                Name = dto.Name,
                Phones = dto.Phones,
                Address = address,
                ProfessionalRegister = dto.ProfessionalRegister,
                User = user
            };

            return dentist;
        }
    }
}