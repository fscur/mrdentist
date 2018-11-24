using MrDentist.Models;
using System;

namespace MrDentist.Data
{
    public interface IOdontogramsDataAccessObject : IDataAccessObject<Odontogram>
    {
        OdontogramEntry GetOdontogramEntry(int odontogramId, DateTime date);
    }
}