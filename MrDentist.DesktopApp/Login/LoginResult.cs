using MrDentist.Models;

namespace MrDentist.DesktopApp.Login
{
    public partial class LoginResult
    {
        public bool Success { get; internal set; }
        public LoginFailReason FailReason {get; internal set; }
        public string ErrorMessage { get; internal set; }
        public User User { get; internal set; }
    }
}