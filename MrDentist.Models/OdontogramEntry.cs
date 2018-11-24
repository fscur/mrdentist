using System;
using System.Collections.Generic;

namespace MrDentist.Models
{
    public class OdontogramEntry
    {
        public int Id { get; private set; }
        public DateTime Date { get; set; }
        public List<IDentalIssue> DentalIssues { get; private set; }

        public OdontogramEntry(int id)
        {
            Id = id;
            DentalIssues = new List<IDentalIssue>();
        }
    }
}