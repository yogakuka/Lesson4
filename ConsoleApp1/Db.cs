using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    class Db: BaseDb
    {
        public Db()
        {
            Users  = new User[] 
            {
                new User("qwe", "asd"),
                new User("sa", "asd"),
                new User("rty", "asd"),
                new User("qqq", "www"),
                new User("qqqq", "wwwq"),
            };
        }

        
    }
}
