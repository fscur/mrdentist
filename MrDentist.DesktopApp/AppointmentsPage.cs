using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MrDentist.Data;

namespace MrDentist.DesktopApp
{
    public partial class AppointmentsPage : Page
    {
        public AppointmentsPage(IDataRepository dataRepository)
        {
            InitializeComponent();
            TitleText = "Agenda";
        }
    }
}
