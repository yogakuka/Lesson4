using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class User
    {
        public User(string login, string password)
        {
            this.Password = password;
            this.Login = login;
        }
        public string Password { get; set; }
        public string Login { get; set; }
    }
}
