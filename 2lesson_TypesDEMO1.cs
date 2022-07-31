using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20220724_TypesDemo_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // DoTestInRange();

            // DoTestLogicalAnd();

            DoTestLogicalOr();

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        private static void DoTestInRange()
        {
            bool f1 = true;
            bool f2 = false;

            int a = 10;
            int b = 20;

            bool f3 = a > b;    // false

            Console.WriteLine("Enter x: ? ");
            int x = int.Parse(Console.ReadLine());

            bool result = (x > a) && (x < b);

            Console.WriteLine("(x > a) && (x < b): {0}", result);
        }

        private static void DoTestLogicalAnd()
        {
            {
                Console.ForegroundColor = ConsoleColor.Red;
                bool res1 = Program.f1(true) & Program.f2(false);

                Console.WriteLine("f1(true) & f2(false): {0}", res1);

                Console.ForegroundColor = ConsoleColor.Cyan;
                bool res2 = Program.f1(false) & Program.f2(true);

                Console.WriteLine("f1(false) & f2(true): {0}", res2);
            }
            Console.WriteLine("----------------------------------------------");
            {
                Console.ForegroundColor = ConsoleColor.Red;
                bool res1 = Program.f1(true) && Program.f2(false);

                Console.WriteLine("f1(true) && f2(false): {0}", res1);

                Console.ForegroundColor = ConsoleColor.Cyan;
                bool res2 = Program.f1(false) && Program.f2(true);

                Console.WriteLine("f1(false) && f2(true): {0}", res2);
            }
        }

        private static void DoTestLogicalOr()
        {
            {
                Console.ForegroundColor = ConsoleColor.Red;
                bool res1 = Program.f1(true) | Program.f2(false);

                Console.WriteLine("f1(true) | f2(false): {0}", res1);

                Console.ForegroundColor = ConsoleColor.Cyan;
                bool res2 = Program.f1(false) | Program.f2(true);

                Console.WriteLine("f1(false) | f2(true): {0}", res2);
            }
            Console.WriteLine("----------------------------------------------");
            {
                Console.ForegroundColor = ConsoleColor.Red;
                bool res1 = Program.f1(true) || Program.f2(false);

                Console.WriteLine("f1(true) || f2(false): {0}", res1);

                Console.ForegroundColor = ConsoleColor.Cyan;
                bool res2 = Program.f1(false) || Program.f2(true);

                Console.WriteLine("f1(false) || f2(true): {0}", res2);

                Console.ForegroundColor = ConsoleColor.Yellow;
                bool res3 = Program.f1(false) || Program.f2(false) || Program.f3(true);

                Console.WriteLine("f1(false) || f2(false) || f3(true): {0}", res2);
            }
        }

        public static bool f1(bool arg)
        {
            Console.WriteLine("f1({0})", arg);

            return arg;
        }

        public static bool f2(bool arg)
        {
            Console.WriteLine("f2({0})", arg);

            return arg;
        }

        public static bool f3(bool arg)
        {
            Console.WriteLine("f3({0})", arg);

            return arg;
        }
    }
}
