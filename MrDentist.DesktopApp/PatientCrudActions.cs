using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrDentist.DesktopApp
{
    public class PatientCrudToolStripActions : ICrudToolStripActions
    {
        public void AddAction()
        {
            System.Windows.Forms.MessageBox.Show("Add");
        }

        public void EditAction()
        {
            System.Windows.Forms.MessageBox.Show("Edit");
        }

        public void RemoveAction()
        {
            System.Windows.Forms.MessageBox.Show("Remove");
        }
    }
}
