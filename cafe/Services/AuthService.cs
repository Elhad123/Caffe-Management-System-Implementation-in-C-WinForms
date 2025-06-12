using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cafe.Data;

namespace cafe.Services
{
    internal class AuthService
    {
        public User Login(string username, string password)
        {
            if (username == null || password == null) InMemorydb.LoggedIn = null;
            InMemorydb.LoggedIn = InMemorydb.Users.FirstOrDefault(i => i.Name == username && i.Password == password);
            return InMemorydb.LoggedIn;
        }
        public void LogOut()
        {
            InMemorydb.LoggedIn = null;
            InMemorydb.Items.Clear();
            InMemorydb.Orders.Clear();


        }

        internal User Register(string username, string password)
        {
            if (!InMemorydb.Users.Any(i => i.Name == username)) {
                User newUser = new User(username, password);
                InMemorydb.Users.Add(newUser);
                return newUser;
            }
            else
            {
                return null;
            }
        }
    }
}
