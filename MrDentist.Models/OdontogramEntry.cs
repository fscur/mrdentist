using System;
using System.Collections.Generic;

namespace MrDentist.Models
{
    public class OdontogramEntry
    {
        public int Id { get; private set; }
        public DateTime Date { get; set; }
        public List<IDentalEvent> DentalEvents { get; set; }
        public Odontogram Odontogram { get; set; }

        public OdontogramEntry(int id)
        {
            Id = id;
        }
    }
}