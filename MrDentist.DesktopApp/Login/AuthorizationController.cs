using MrDentist.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrDentist.DesktopApp.Login
{
    public class AuthorizationController
    {
        public LoginResult Login(string email, string password)
        {
            if (!IsValidEmail(email))
            {
                return new LoginResult()
                {
                    Success = false,
                    FailReason = LoginFailReason.InvalidEmail,
                    ErrorMessage = "O email informado não é valido."
                };
            }

            if (!IsValidPassword(password))
            {
                return new LoginResult()
                {
                    Success = false,
                    FailReason = LoginFailReason.InvalidPassword,
                    ErrorMessage = "O password não é válido."
                };
            }

            return new LoginResult()
            {
                Success = true
            };
        }

        private bool IsValidPassword(string password)
        {
            return !string.IsNullOrEmpty(password);
        }

        private bool IsValidEmail(string email)
        {
            return !string.IsNullOrEmpty(email);
        }
    }
}
