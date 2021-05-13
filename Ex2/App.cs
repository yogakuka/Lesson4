using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Ex2
{
    class App
    {
        public void Start()
        {
            int[] array = StaticClass.ReadFile("..\\..\\Array.txt");
            Console.WriteLine($"{StaticClass.ArrayCounter(array)}");
            Console.ReadLine();
        }
        
    }
}
