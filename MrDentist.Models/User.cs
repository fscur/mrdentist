using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrDentist.Models
{
    public class User
    {
        public int Id { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public UserType Type { get; private set; }

        public User(int id, string email, string password, UserType type)
        {
            Id = id;
            Email = email;
            Password = password;
            Type = type;
        }
    }
}
