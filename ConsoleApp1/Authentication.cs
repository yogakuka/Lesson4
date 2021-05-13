using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Authentication
    {
        static public bool Auth(BaseDb users, View view)
        {
            int count = 2;
            do
            {
                view.WriteLine("логин ");
                string login = view.ReadLine();
                view.WriteLine("пароль ");
                string password = view.ReadLine();

                foreach (User user in users.Users)
                {
                    string validLogin = user.Login;
                    string validPassword = user.Password;
                    if ( 
                        login == validLogin
                        && password == validPassword
                   )
                    {
                        return true;
                    }
                }
            } while (count-- > 0);
            return false;
        }
    }
}
