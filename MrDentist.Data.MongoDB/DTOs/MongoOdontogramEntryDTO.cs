using MrDentist.Models;
using System;
using System.Collections.Generic;

namespace MrDentist.Data.MongoDB.DTOs
{
    internal class MongoOdontogramEntryDTO
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int OdontogramId { get; set; }
    }

    internal static partial class OdontogramEntryExtensions
    {
        public static MongoOdontogramEntryDTO ToDto(this OdontogramEntry obj, int odontogramId)
        {
            if (obj == null)
            {
                throw new System.ArgumentNullException(nameof(obj));
            }

            return new MongoOdontogramEntryDTO()
            {
                Id = obj.Id,
                Date = obj.Date,
                OdontogramId = odontogramId
            };
        }

        public static OdontogramEntry ToObj(this MongoOdontogramEntryDTO dto, IDataRepository repository)
        {
            if (dto == null)
            {
                throw new System.ArgumentNullException(nameof(dto));
            }

            if (repository == null)
            {
                throw new System.ArgumentNullException(nameof(repository));
            }

            var entry = new OdontogramEntry(dto.Id)
            {
                Date = dto.Date
            };

            return entry;
        }
    }
}