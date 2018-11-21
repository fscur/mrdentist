using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MrDentist.Models;

namespace MrDentist.DesktopApp.Login
{
    public partial class LoginControl : UserControl
    {
        AuthorizationController _loginController;

        public event EventHandler<User> LoginSucceeded;
        public event EventHandler<LoginResult> LoginFailed;

        public LoginControl()
        {
            InitializeComponent();
            InitializeEvents();

            _loginController = new AuthorizationController();
        }

        private void InitializeEvents()
        {
            _buttonEntry.Click += (s, e) =>
            {
                var email = _textEmail.Text;
                var password = _textEmail.Text;
                var loginResult = _loginController.Login(email, password);

                if (loginResult.Success)
                {
                    RaiseLoginSucceeded(loginResult.User);
                }
                else
                {
                    _textError.Text = loginResult.ErrorMessage;
                    RaiseLoginFailed(loginResult);
                }
            };

            _textEmail.Enter += (s, e) => {
                _textError.Clear();
            };

            _textPassword.Enter += (s, e) => {
                _textError.Clear();
            };

            _textError.Enter += (s, e) => {
                ActiveControl = _textEmail;
            };
        }

        private void RaiseLoginSucceeded(User user)
        {
            if (LoginSucceeded != null)
                LoginSucceeded.Invoke(this, user);
        }

        private void RaiseLoginFailed(LoginResult loginResult)
        {
            if (LoginFailed != null)
                LoginFailed.Invoke(this, loginResult);
        }
    }
}
