using MrDentist.Models;
using MrDentist.Models.Factories;
using System;
using System.Collections.Generic;

namespace MrDentist.Data.MongoDB.DTOs
{
    internal class MongoDentalIssueDTO
    {
        public int Id { get; set; }
        public IPointF Position { get; set; }
        public DentalIssueType IssueType { get; set; }
        public int OdontogramEntryId { get; set; }
    }

    internal static partial class DentalIssueExtensions
    {
        public static MongoDentalIssueDTO ToDto(this IDentalIssue obj, int odontogramEntryId)
        {
            if (obj == null)
            {
                throw new System.ArgumentNullException(nameof(obj));
            }

            DentalIssueType issueType = DentalIssueType.Cavity;

            if (obj is Cavity)
                issueType = DentalIssueType.Cavity;
            else if (obj is Restoration)
                issueType = DentalIssueType.Restoration;

            return new MongoDentalIssueDTO()
            {
                Id = obj.Id,
                Position = obj.Shape.Position,
                IssueType = issueType,
                OdontogramEntryId = odontogramEntryId
            };
        }

        public static IDentalIssue ToObj(this MongoDentalIssueDTO dto, IDataRepository repository)
        {
            if (dto == null)
            {
                throw new System.ArgumentNullException(nameof(dto));
            }

            if (repository == null)
            {
                throw new System.ArgumentNullException(nameof(repository));
            }

            return DentalIssueFactory.Create(dto.Id, dto.IssueType, dto.Position);
        }
    }
}