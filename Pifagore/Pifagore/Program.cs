using System;

namespace Pifagore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t\tТаблица ПИФАГОРА размерностью X на У");
            Console.Write("Введите X:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите Y:");
            int y = Convert.ToInt32(Console.ReadLine());
            if (x > 0 & y > 0)
            {
                for (int m = 1; m <= y; m++)
                {
                    for (int n = 1; n <= x; n++)
                    {
                        int res = n * m;
                        Console.Write("{0, 4}", res);
                    }
                    Console.WriteLine();
                }
            }
            else
                Console.WriteLine("Такую таблицу нам не заказывали:)");
            Console.ReadKey();
        }
    }
}
