using System;

namespace A_DoG
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 60;
            int y = 15;
            Console.CursorVisible = false;
            Console.SetCursorPosition(x, y);
            Console.Write('@');
            ConsoleKey key;
            while ((key = Console.ReadKey().Key) != ConsoleKey.Escape)
            {
                switch (key)
                {
                    case ConsoleKey.RightArrow:
                        x = x + 1;
                        break;
                    case ConsoleKey.LeftArrow:
                        x = x - 1;
                        break;
                    case ConsoleKey.UpArrow:
                        y = y - 1;
                        break;
                    case ConsoleKey.DownArrow:
                        y = y + 1;
                        break;
                    default:
                        Console.Beep();
                        break;
                }
                Console.Clear();
                Console.SetCursorPosition(x, y);
                Console.Write("@");
            }
        }
    }
}