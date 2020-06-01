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

        static double FactorialRecursion(int n)
        {
            countFR++;
            return n == 0 ? 1 : n * FactorialRecursion(n - 1);
        }

        static double FactorialIteration(int n)
        {
            double result = 1;
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
            int n = 30;
            Console.WriteLine($"n({n}) = {FactorialRecursion(n)} countFR = {countFR}");
            Console.WriteLine($"n({n}) = {FactorialIteration(n)} countFI = {countFI}");
            Console.ReadLine();
        }
    }
}
