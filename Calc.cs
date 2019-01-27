using System;


namespace Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Простейшие математические вычисления для двух переменных");
            Console.Write("Введите первое число:");
            Double a, b;
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"a={a}");
            Console.Write("Введите второе число:");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"b={b}");
            Double add = a + b;
            Double sub = a - b;
            Double mult = a * b;
            Double div = a / b;
            Console.WriteLine($"\na+b={add}, a-b={sub}, a*b={mult}, a/b={div.ToString("F4")}");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
