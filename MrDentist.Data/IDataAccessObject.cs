using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrDentist.Data
{
    public interface IDataAccessObject<T>
    {
        bool Add(T obj);
        bool Remove(T obj);
        bool Update(T obj);
        T Get(int id);
        IEnumerable<T> All { get; }
    }
}
