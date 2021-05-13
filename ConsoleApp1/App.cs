using System;

namespace ConsoleApp1
{
    public class App
    {
        public   void Start()
        {
            if (Authentication.Auth(new Db(), new ConsoleView()))
            {
                Console.WriteLine("+");
            }
            else
            {
                Console.WriteLine("-");
            }
        }
    }
}