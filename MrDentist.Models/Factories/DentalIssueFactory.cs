using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrDentist.Models.Factories
{
    public static class DentalIssueFactory
    {
        public static IDentalIssue Create(int id, DentalIssueType type, IPointF position)
        {
            switch (type)
            {
                case DentalIssueType.Cavity:
                   return new Cavity(id, position);
                case DentalIssueType.Restoration:
                    return new Restoration(id, position);
                default:
                    return null;
            }
        }
    }
}
