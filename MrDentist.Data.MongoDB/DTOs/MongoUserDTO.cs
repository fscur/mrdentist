using MrDentist.Models;

namespace MrDentist.Data.MongoDB.DTOs
{
    internal class MongoUserDTO
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public UserType Type { get; set; }
    }

    internal static partial class UserExtensions
    {
        public static MongoUserDTO ToDto(this User obj)
        {
            if (obj == null)
            {
                throw new System.ArgumentNullException(nameof(obj));
            }

            return new MongoUserDTO()
            {
                Id = obj.Id,
                Email = obj.Email,
                Password = obj.Password,
                Type = obj.Type
            };
        }

        public static User ToObj(this MongoUserDTO dto, IDataRepository repository)
        {
            if (dto == null)
            {
                throw new System.ArgumentNullException(nameof(dto));
            }

            if (repository == null)
            {
                throw new System.ArgumentNullException(nameof(repository));
            }

            return new User(
                dto.Id,
                dto.Email,
                dto.Password,
                dto.Type);
        }
    }
}