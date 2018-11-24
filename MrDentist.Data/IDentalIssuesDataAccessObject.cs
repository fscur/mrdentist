using MrDentist.Models;
using System.Collections.Generic;

namespace MrDentist.Data
{
    public interface IDentalIssuesDataAccessObject : IDataAccessObject<IDentalIssue>
    {
        IEnumerable<IDentalIssue> GetDentalIssuesByOdontogramEntryId(int id);
    }
}