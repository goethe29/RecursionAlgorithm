using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex001Factorial
{
    class Program
    {
        static int countFR = 0;
        static int countFI = 0;

        static decimal FactorialRecursion(int n)
        {
            countFR++;
            return n == 0 || n == 1 ? 1 : n * FactorialRecursion(n - 1);
        }

        static decimal FactorialIteration(int n)
        {
            decimal result = 1;
            countFI++;
            for (int i = n; i > 1; i--)
            {
                countFI++;
                result *= i;
            }
            return result;
        }




        static void Main(string[] args)
        {
            int n = 10;
            Console.WriteLine($"n({n}) = {FactorialRecursion(5)} countFR = {countFR}");
            Console.WriteLine($"n({n}) = {FactorialIteration(5)} countFI = {countFI}");

        }
    }
}
