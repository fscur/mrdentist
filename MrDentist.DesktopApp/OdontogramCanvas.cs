using MrDentist.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MrDentist.DesktopApp
{
    public class OdontogramEntryCanvas : PictureBox
    {
        private Timer timer;

        public List<IDentalIssueShape> Shapes { get; set; }

        public OdontogramEntryCanvas() : base()
        {
            this.DoubleBuffered = true;

            this.Shapes = new List<IDentalIssueShape>();

            timer = new Timer();
            timer.Tick += (s, e) =>
            {
                this.Invalidate();
            };

            timer.Start();
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            Cursor = Cursors.Hand;
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            Cursor = Cursors.Default;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            
            foreach (var shape in Shapes)
                OdontogramPainter.Draw(e.Graphics, shape);
        }
    }
}
