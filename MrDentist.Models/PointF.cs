using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrDentist.Models
{
    public class PointF : IPointF
    {
        public float X { get; private set; }
        public float Y { get; private set; }

        public PointF(float X, float Y)
        {
            this.X = X;
            this.Y = Y;
        }
    }
}
