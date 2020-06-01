using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex012Sets
{
    class Program
    {
        static void Main(string[] args)
        {
            // Упорядоченным разбиением множества
            // Разбиение на 3 части множества из n элементов 
            // можно представить n-разрядным числом в 3-ичной системе счисления

            // Существует ровно 3^n различных разбиений 
            // множества bp n элементов на 3 части

            int n = 3;
            int group = 3;
            int p = (int)(Math.Pow(group, n));
            string[] s =new string[group];
            int count = 1;
            for (int i = 0; i < p; i++)
            {
                int k = i;
                for (int c = 0; c < s.Length; c++) s[c] = "";
                for (int j = 1; j <= n; j++)
                {
                    int r = k % group;
                    s[r] = s[r] + j.ToString() + " ";
                    k = k / group;
                }
                Console.Write($"{count,5}: ");
                for (int c = 0; c < s.Length; c++)
                    Console.Write($"{s[c],20}");
                Console.WriteLine();
                count++;
            }

        }
    }
}
