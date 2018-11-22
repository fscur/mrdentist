using MrDentist.Models;

namespace MrDentist.Data
{
    public interface IOdontogramsDataAccessObject : IDataAccessObject<Odontogram>
    {
        Odontogram GetByPatientId(int id);
    }
}