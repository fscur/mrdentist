using MrDentist.Models;
using System;
using System.Collections.Generic;

namespace MrDentist.Data.MongoDB.DTOs
{
    internal class MongoOdontogramEntryDTO
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public List<IDentalEvent> DentalEvents { get; set; }
        public int OdontogramId { get; set; }
    }

    internal static partial class OdontogramEntryExtensions
    {
        public static MongoOdontogramEntryDTO ToDto(this OdontogramEntry obj)
        {
            if (obj == null)
            {
                throw new System.ArgumentNullException(nameof(obj));
            }

            return new MongoOdontogramEntryDTO()
            {
                Id = obj.Id,
                Date = obj.Date,
                DentalEvents = obj.DentalEvents,
                OdontogramId = obj.Odontogram.Id
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

            return new OdontogramEntry(dto.Id)
            {
                Date = dto.Date, 
                Odontogram = repository.Odontograms.Get(dto.Id),
                DentalEvents = dto.DentalEvents
            };  
        }
    }
}