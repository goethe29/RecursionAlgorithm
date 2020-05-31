using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex002Fibonacci
{
    class Program
    {
        static decimal fRec = 0;
        static decimal fIte = 0;
        

        static decimal FibonacciRecursion(int n)
        {
            fRec++;
            return n == 0 || n == 1 ? 1 : FibonacciRecursion(n - 1) + FibonacciRecursion(n - 2);
        }

        static decimal FibonacciIteration(int n)
        {
            fIte++;
            decimal result = 0;
            decimal f0 = 1;
            decimal f1 = 1;
            for (int i = 2; i <= n;  i++)
            {
                result = f0 + f1;

                f0 = f1;
                f1 = result;
                fIte++;
            }
            return result;
        }

        static void Main(string[] args)
        {
            //# 1 2 3 4 5 6
            //V 1 1 2 3 5 8
            int n = 20;
            Console.WriteLine($"FibonacciRecursion({n}) = {FibonacciRecursion(n)} fRec = {fRec}");
            Console.WriteLine($"FibonacciIteration({n}) = {FibonacciIteration(n)} fIte = {fIte}");
          
        }
    }
}
