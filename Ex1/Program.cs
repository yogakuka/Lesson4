using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[20];
            int i;
            int min = -10000;
            int max = 10000;
            int n = 0;
            Random rnd = new Random();
            for (i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(min, max);
                Console.WriteLine($"{array[i]}");
            }
            for (i = 0; array.Length - 1 > i; i++)
            {
                Console.WriteLine($"{array[i]},{array[i + 1]}");
                if ((array[i] % 3) == 0 & (array[i + 1] % 3) > 0)
                {
                    n++;
                }
                else
                {
                    if ((array[i] % 3) > 0 & (array[i + 1] % 3) == 0)
                    {
                        n++;
                    }
                }
            }
            Console.WriteLine($"{n}");
        }
    }
}
