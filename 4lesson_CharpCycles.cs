using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2022_814_CyclesDemo
{
    class Program
    {
        static Random rnd = new Random();

        static void Main(string[] args)
        {
            int i = 0;
            while (i < 100)    // выполнять пока не сделаем 100 итераций
            {
                Console.Write("Iteration #: {0}", i + 1);

                int currentValue = rnd.Next(-100, 101);

                Console.Write(", currentValue: {0}", currentValue);

                if (currentValue < 0)    // закончить выполнение, если появилось отрицательное число
                {
                    //break;
                }

                if (currentValue < 0)    // закончить выполнение, если появилось отрицательное число
                {
                    continue;    // игнорировать отрицательные числа
                }

                i++;
                Console.WriteLine();
            }

            Console.ReadKey();
            Console.WriteLine();

            {
                int a = 125;
                int b = 50;

                Console.Write("NOD ({0}, {1}):", a, b);

                while (a != b)
                {
                    if (a > b)
                    {
                        a -= b;    // a = a - b;
                    }
                    else
                    {
                        b -= a;
                    }
                }

                Console.WriteLine("{0}", a);
                // Console.WriteLine("NOD ({0}, {1}): {2}", a, b, a);
            }

            {
                Console.ForegroundColor = ConsoleColor.Red;

                int a = 125;
                int b = 50;

                Console.Write("NOD ({0}, {1}):", a, b);

                for (; a != b; )
                {
                    if (a > b)
                    {
                        a -= b;    // a = a - b;
                    }
                    else
                    {
                        b -= a;
                    }   
                }

                Console.WriteLine("{0}", a);
                // Console.WriteLine("NOD ({0}, {1}): {2}", a, b, a);
            }

            // Применяем когда заранее известно кол-во итераций, которое нужно выполнить
            for (int j = 0; j < 10; j++)
            {

            }

            for (int k = 10 - 1; k >= 0; k--)
            {

            }

            // !!! единственно допустимый вариант бесконечного цикла !!!
            //for ( ; ; )
            //{
            //    if (<force major>)
            //    {
            //        break;
            //    }
            //}

            Console.ReadKey();
        }
    }
}
