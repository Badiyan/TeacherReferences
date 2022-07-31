using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20220731_CharStringDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch = '╔';     // unicode

            Console.Write(ch);
            Console.WriteLine("══╗");
            Console.WriteLine("╚══╝");
            Console.WriteLine('\u2191');

            for (ushort i = 0x30; i <= 0x39; i++)
            {
                Console.WriteLine("{0} - ({1}) [{1:X}]", (char)i, i);
            }

            Console.Write("Enter char: ? ");

            // Вычитавание одного символа без подверждения
            char ch2 = Console.ReadKey().KeyChar;
            Console.WriteLine();

            if (char.IsControl(ch2))
            {
                Console.WriteLine("<{0}> is control char", ch2);
            }
            else
            {
                Console.WriteLine("<{0}>", ch2);
            }

            string s1 = "abcde6545";

            // Доступ по позиции!!!
            for (int i = 0; i < s1.Length; i++)
            {
                Console.Write("{0}\t", s1[i]);
            }
            Console.WriteLine();

            // !!! доступ к отдельным символам только на чтение !!!
            // s1[2] = ';';

            string s1Copy = s1.Replace('c', ';');
            Console.WriteLine("s1Copy: {0}", s1Copy);

            if (s1.Contains("e654"))
            {
                Console.WriteLine("\"e654\" is substring of \"{0}\"", s1);
            }

            Console.ReadKey();
        }
    }
}
