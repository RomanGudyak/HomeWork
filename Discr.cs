using System;

namespace Discr
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите коэффициенты для квадратного уравнения ax^2+bx+c=0 ");
            double a, b, c, discr;
            Console.Write("a=");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b=");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("c=");
            c = Convert.ToDouble(Console.ReadLine());
            discr = Math.Pow(b, 2) - 4 * a * c;
            Console.WriteLine($"Дискриминант= {discr.ToString()}");
            if (discr > 0)
            {
                double x1 = ((-b + Math.Sqrt(discr)) / (2 * a));
                double x2 = ((-b - Math.Sqrt(discr)) / (2 * a));
                Console.WriteLine($"X1= {x1.ToString("F4")}");
                Console.WriteLine($"X2= {x2.ToString("F4")}");
            }
            else
                if (discr == 0)
                {
                double x =-b / (2 * a);
                    Console.WriteLine($"X= {x.ToString("F4")}");
                }
                 else
                Console.WriteLine("Действительных корней уравнения нет");
                Console.ReadKey();
        }
    }
}
