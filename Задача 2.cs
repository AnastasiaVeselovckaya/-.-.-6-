using System;

namespace Задача_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            double a = 0;
            double b = 0;
            Console.WriteLine("Введите два числа");
            Console.Write("a= ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b= ");
            b = Convert.ToDouble(Console.ReadLine());
            {
                sum = a * b;
            }
            Console.WriteLine("{0}*{1}", a, b);
            Console.WriteLine("Результат вычисления :{0}", Math.Round(sum, 1));
            Console.ReadLine();
        }
    }
}