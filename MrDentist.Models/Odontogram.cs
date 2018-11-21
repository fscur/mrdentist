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
        public int Id { get; set; }
        public Image BaseImage { get; set; }
        public List<OdontogramEntry> Entries { get; set;}
    }
}
