using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20220220_CSharpInto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "First .Net application";

            // вывод в консоль
            Console.WriteLine("Hello, LevelUp!!!");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(10, 10);
            Console.WriteLine('*');
            Console.SetCursorPosition(11, 11);
            Console.WriteLine('*');
            Console.SetCursorPosition(12, 12);
            Console.WriteLine('*');
            Console.SetCursorPosition(13, 13);
            Console.WriteLine('*');


            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");

            Console.ReadKey();    // ожидание нажатия любой клавиши
        }
    }
}
