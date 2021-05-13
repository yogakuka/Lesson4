using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Ex2
{
    class StaticClass
    {
        static public int[] ReadFile(string file)
        {
            int[] ar = new int[0];
            StreamReader sr = new StreamReader(file);
            int i = 0;
            while (!sr.EndOfStream)
            {
                Array.Resize(ref ar, ar.Length + 1);
                ar[i]=int.Parse(sr.ReadLine());
                //Console.WriteLine($"{ar[i]}");
                i++;
                
            }
            return (ar);
        }

        static public int ArrayCounter(int[] array)
        {
            int i;
            int n = 0;
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
            return (n);
        }
    }
}
