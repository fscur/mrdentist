using MrDentist.Models;

namespace MrDentist.Data.MongoDB.DTOs
{
    internal class MongoOdontogramDTO
    {
        public int Id { get; set; }
        public string BaseImageUrl { get; set; }
    }

    internal static partial class OdontogramExtensions
    {
        public static MongoOdontogramDTO ToDto(this Odontogram obj)
        {
            if (obj == null)
            {
                throw new System.ArgumentNullException(nameof(obj));
            }

            return new MongoOdontogramDTO()
            {
                Id = obj.Id,
                BaseImageUrl = obj.BaseImageUrl
            };
        }

        public static Odontogram ToObj(this MongoOdontogramDTO dto, IDataRepository repository)
        {
            if (dto == null)
            {
                throw new System.ArgumentNullException(nameof(dto));
            }

            if (repository == null)
            {
                throw new System.ArgumentNullException(nameof(repository));
            }

            var odontogram = new Odontogram(dto.Id) {
                BaseImageUrl = dto.BaseImageUrl,
                BaseImage = System.Drawing.Image.FromFile(dto.BaseImageUrl),
            };

            return odontogram;
        }
    }
}