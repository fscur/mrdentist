using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MrDentist.DesktopApp
{
    public class CrudToolStrip : ToolStrip
    {
        public CrudToolStrip(ICrudToolStripActions actions)
        {
            var addMenuItem = new ToolStripButton(Properties.Resources.plus_1);
            addMenuItem.Click += (s, e) => { actions.AddAction(); };
            this.Items.Add(addMenuItem);

            var editMenuItem = new ToolStripButton(Properties.Resources.pencil_1);
            editMenuItem.Click += (s, e) => { actions.EditAction(); };
            this.Items.Add(editMenuItem);

            var removeMenuItem = new ToolStripButton(Properties.Resources.cross_1);
            removeMenuItem.Click += (s, e) => { actions.RemoveAction(); };
            this.Items.Add(removeMenuItem);
        }
    }
}
