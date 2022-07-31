using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20220724_IncDecDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;

            int b = ++a;

            Console.WriteLine("a = {0}, b = {1}", a , b);

            int c = a++ + 5;

            Console.WriteLine("a = {0}, c = {1}", a, c);

            Console.ReadKey();
        }
    }
}
