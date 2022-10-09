using System;

namespace Задача_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            double a = 0;
            double b = 0;
            double c = 0;
            Console.WriteLine("Vvedite 3 4isla");
            Console.Write("a= ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b= ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("c= ");
            c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("({0}+{1})+{2}={0}+({1}+{2})", Math.Round(a, 2), Math.Round(b, 2), Math.Round(c, 2));
            Console.ReadLine();
        }
    }
}