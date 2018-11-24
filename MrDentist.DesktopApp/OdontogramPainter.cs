using MrDentist.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrDentist.DesktopApp
{
    public static class PointPainter
    {
        public static void Draw(Graphics g, Models.Point point) {
            using (var brush = new SolidBrush(point.Color))
            {
                var x = point.Position.X - (point.Size.Width / 2);
                var y = point.Position.Y - (point.Size.Height / 2);

                g.FillEllipse(brush, new RectangleF(new System.Drawing.PointF(x,y), point.Size));
            }
        }
    }

    public static class OdontogramPainter
    {
        public static void Draw(Graphics g, IDentalIssueShape shape)
        {
            if (shape is Models.Point)
                PointPainter.Draw(g, shape as Models.Point);
        }
    }
}
