using MrDentist.Models;

namespace MrDentist.Data.MongoDB.DTOs
{
    internal class MongoAddressDTO
    {
        public int Id { get; set; }
        public string Description { get; set; }
    }

    public static partial class AddressExtensions
    {
        internal static MongoAddressDTO ToDto(this Address user)
        {
            return new MongoAddressDTO()
            {
                Id = user.Id,
                Description = user.Description
            };
        }

        internal static Address ToObj(this MongoAddressDTO dto, IDataRepository repository)
        {
            return new Address(
                dto.Id)
            {
                Description = dto.Description
            };
        }
    }
}