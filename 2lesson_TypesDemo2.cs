using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20220724_TypesDemo_2
{
    class Program
    {
        const double EPS = 0.0001;

        static void Main(string[] args)
        {
            double d1 = 1.99;

            double d2 = 1.0;

            // :(
            Console.ForegroundColor = ConsoleColor.Green;
            if (d1 == d2)
            {
                Console.WriteLine("d1 == d2");
            }
            else
            {
                Console.WriteLine("d1 <> d2");
            }

            Console.ForegroundColor = ConsoleColor.Cyan;
            if (Math.Abs(d1 - d2) <= EPS)
            {
                Console.WriteLine("d1 == d2");
            }
            else
            {
                Console.WriteLine("d1 <> d2");
            }

            Console.WriteLine("Enter d1: ? ");

            string strInput = Console.ReadLine();
            //   d1 = double.Parse(strInput);

            //d1 = Convert.ToDouble(strInput);
            bool flagOk = double.TryParse(strInput, out d1);

            if (flagOk)    // true
            {
                Console.WriteLine("d1: {0}", d1);
            }
            else    // false
            {
                Console.WriteLine(":(");
            }
            

            Console.ReadKey();
        }
    }
}
