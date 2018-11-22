using MrDentist.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrDentist.Data
{
    public interface IDentistsDataAccessObject : IDataAccessObject<Dentist>
    {
        Dentist GetByUser(User user);
    }
}
