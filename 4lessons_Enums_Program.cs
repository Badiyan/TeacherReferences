using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20220814_EnumsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int direction = 2;    // left

                // оператор множественного выбора
                switch (direction)
                {
                    case 1:  // left
                        Console.WriteLine("Left");
                        break;
                    case 2:  // right
                        Console.WriteLine("Right");
                        break;
                    case 3:  // Down
                        Console.WriteLine("Down");
                        break;
                    case 4:  // Up
                        Console.WriteLine("Up");
                        break;
                    default:
                        Console.WriteLine("Wrong direction!!!");
                        break;
                }
            }

            {
                // value type - 0
                Direction dir1;
                
                dir1 = Direction.Up;

                string answer = string.Empty;
                do
                {
                    Console.WriteLine("Enter direction: ? ");
                    answer = Console.ReadLine();
                } while (!Enum.TryParse(answer, out dir1) 
                        || dir1 < Direction.Left || dir1 > Direction.Up);

                switch (dir1)
                {
                    case Direction.Left:
                        Console.WriteLine("Left");
                        break;
                    case Direction.Right:
                        Console.WriteLine("Right");
                        break;
                    case Direction.Down:
                        Console.WriteLine("Down");
                        break;
                    case Direction.Up:
                        Console.WriteLine("Up");
                        break;
                    default:
                        Console.WriteLine("Wrong direction!!!");
                        break;
                }

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("dir1: {0}, ({1})", dir1, (int)dir1);
            }

            int oldX = Console.CursorLeft;
            int oldY = Console.CursorTop;

            ConsoleColor oldColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;

            for (int x = 3; x < 5; x++)
            {
                Console.SetCursorPosition(x, 2);
                Console.Write((char)Border.HorizontalLine);
            }

            Console.SetCursorPosition(5, 2);
            Console.Write((char)Border.RightTopCorner);

            Console.SetCursorPosition(2, 2);
            Console.Write((char)Border.LeftTopCorner);

            Console.ForegroundColor = oldColor;

            Console.CursorLeft = oldX;
            Console.CursorTop = oldY;


            Console.WriteLine("Press any key...");

            Console.CursorVisible = false;

            Console.ReadKey();
        }
    }
}
