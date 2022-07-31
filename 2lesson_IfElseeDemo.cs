using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElseDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // DoTestIf();

            int a = 110;
            int b = 81;

            int min = a;
            int max = b;

            if (a > b)
            {
                min = b;
                max = a;
            }

            Console.WriteLine("min = {0}, max = {1}", min, max);

            Console.ReadKey();
        }

        private static void DoTestIf()
        {
            int a = 3;
            int b = 10;

            // (+)
            if (a < 3)
            {
                b++;
            }
            else
            {
                --b;
                --b;
            }

            // (-)
            if (a < 3)
            {
                b++;
            }
            else
            {
                --b;
            }

            // (-)
            if (a < 3)
                b++;
            else
                --b;
            --b;

            if (a < 3)
            {

            }
            else
            {
                b += 6;    // !!!
                if (b > 10)
                {
                    ++a;
                }
            }

            // :(
            if (a < 3)
            {

            }
            else    // !!!
            {    // !!!
                if (b > 10)    // !!!
                {    // !!!
                    ++a;    // !!!
                }    // !!!
            }    // !!!
        }
    }
}
