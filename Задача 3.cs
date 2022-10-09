using System;
using System.Linq;

namespace Задача_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0;
            double b = 0;
            double c = 0;
            Console.WriteLine("Введите 3 числа");
            Console.Write("a= ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b= ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("c= ");
            c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("{0}*{1}*{2} = {2}*{1}*{0}", a, b, c);
            Console.ReadLine();
        }
    }
}