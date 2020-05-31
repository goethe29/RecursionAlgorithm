using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex000Intro
{
    class Program
    {
        static int countPR = 0;
        static int countPI = 0;

        static void Main(string[] args)
        {
            Console.WriteLine($"PowRecursion(2,30) = {PowRecursion(2, 30)} {countPR}");
            Console.WriteLine($"PowIteration(2,30) = {PowIteration(2, 30)} {countPI}");
        }


        static double PowRecursion(double a, int n)
        {
            countPR++;
            if (n == 0) return 1;
            else if (n % 2 == 1) return a * PowRecursion(a, n - 1);
            else return PowRecursion(a * a, n / 2);
        }

        static double PowIteration(double a, int n)
        {
            countPI++;
            double result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= a;
                countPI++;
            }
            return result;
        }

    }
}
