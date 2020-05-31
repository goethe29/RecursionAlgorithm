using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionAlgorithm
{
    class Program
    {
        static decimal Factorial(int n)
        {
            return n == 0 || n == 1 ? 1 : n * Factorial(n - 1);
        }

        static void Main(string[] args)
        {
        }
    }
}
