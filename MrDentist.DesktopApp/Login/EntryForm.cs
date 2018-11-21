using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MrDentist.DesktopApp.Login
{
    public partial class EntryForm : Form
    {
        internal bool TryLogin()
        {
            this.ShowDialog();

            return _loginSucceeded;
        }

        private bool _loginSucceeded;

        public EntryForm()
        {
            InitializeComponent();

            _loginControl.LoginSucceeded += (s, e) =>
            {
                _loginSucceeded = true;
                this.Close();
            };

            _loginControl.LoginFailed += (s, e) =>
            {
                MessageBox.Show(e.ErrorMessage);
            };
        }
    }
}
