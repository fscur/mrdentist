using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrDentist.Models
{
    public class Odontogram
    {
        public int Id { get; private set; }
        public string BaseImageUrl { get; set; }
        public List<OdontogramEntry> Entries { get; private set;}

        public Odontogram(int id)
        {
            Id = id;
            Entries = new List<OdontogramEntry>();
        }
    }
}
