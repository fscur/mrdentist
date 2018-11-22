using System.Collections.Generic;
using MrDentist.Models;

namespace MrDentist.Data.Memory
{
    internal class UsersDataAccessObject : IUsersDataAccessObject
    {
        public IEnumerable<User> All => throw new System.NotImplementedException();

        public bool Add(User obj)
        {
            throw new System.NotImplementedException();
        }

        public User Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public bool Remove(User obj)
        {
            throw new System.NotImplementedException();
        }

        public bool Update(User obj)
        {
            throw new System.NotImplementedException();
        }
    }
}