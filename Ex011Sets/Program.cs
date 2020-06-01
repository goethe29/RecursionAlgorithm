using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex011Sets
{
    class Program
    {
        static void Main(string[] args)
        {
            // Перебор подмножеств конечного множества
            // Перебор подмножеств фиксированной мощности

            string s = "ABCD";
            int n = s.Length;

            //for (int i = 0; i < n - 2; i++)
            //{
            //    for (int j = i + 1; j < n - 1; j++)
            //    {
            //        for (int k = j + 1; k < n; k++)
            //        {
            //            Console.WriteLine($"[{s[i]} {s[j]} {s[k]}]");
            //            //Console.WriteLine($"[{i + 1} {j + 1} {k + 1}]");
            //        }
            //    }
            //}

            ////Console.Clear();
            //Console.ReadLine();
            //Console.WriteLine();
            // Перебор всех подмножеств

            int p = (int)Math.Pow(2, n);
           
            int h = 0;
            for (int i = 0; i < p; i++)
            {
                h = i;
                Console.Write("[ ");
                for (int j = 1; j <= n; j++)
                {
                    if (h % 2 == 0)
                    {
                        //Console.Write($"{j} ");
                        Console.Write($"{s[j - 1]} ");
                    }
                    h /= 2;
                }
                Console.WriteLine("]");
            }

            
            





        }
    }
}
