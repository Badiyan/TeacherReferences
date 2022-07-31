using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20220731_BitOpsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Bit "AND" - &

            {
                byte arg1 = 0b00001111;    // 0x0F
                //byte arg2 = 0b01010101;    // 0x55
                byte arg2 = 0b10101010;    // 0xAA

                //Convert.ToString()

                Console.WriteLine("arg1: {0,8}", Convert.ToString(arg1, 2));
                Console.WriteLine("arg2: {0,8}", Convert.ToString(arg2, 2));

                byte result = (byte)(arg1 & arg2);    // явное преобразование типа
                Console.WriteLine("   &: {0,8}", Convert.ToString(result, 2));
                // Console.WriteLine("   &: {0,32}", Convert.ToString(arg1 & arg2, 2));
            }

            #endregion

            Console.WriteLine("-------------------------------------");

            #region Bit "OR" - |

            {
                byte arg1 = 0b00001111;    // 0x0F
                //byte arg2 = 0b01010101;    // 0x55
                byte arg2 = 0b10101010;    // 0xAA

                //Convert.ToString()

                Console.WriteLine("arg1: {0,8}", Convert.ToString(arg1, 2));
                Console.WriteLine("arg2: {0,8}", Convert.ToString(arg2, 2));

                byte result = (byte)(arg1 | arg2);    // явное преобразование типа
                Console.WriteLine("   |: {0,8}", Convert.ToString(result, 2));
                // Console.WriteLine("   &: {0,32}", Convert.ToString(arg1 & arg2, 2));
            }

            #endregion

            Console.WriteLine("-------------------------------------");

            #region Bit "XOR" - ^

            {
                byte arg1 = 0b00001111;    // 0x0F
                //byte arg2 = 0b01010101;    // 0x55
                byte arg2 = 0b10101010;    // 0xAA

                //Convert.ToString()

                Console.WriteLine("arg1: {0,8}", Convert.ToString(arg1, 2));
                Console.WriteLine("arg2: {0,8}", Convert.ToString(arg2, 2));

                byte result = (byte)(arg1 ^ arg2);    // явное преобразование типа
                Console.WriteLine("   ^: {0,8}", Convert.ToString(result, 2));
                // Console.WriteLine("   &: {0,32}", Convert.ToString(arg1 & arg2, 2));
                byte result2 = (byte)(result ^ arg2);    // явное преобразование типа
                Console.WriteLine("  ^^: {0,8}", Convert.ToString(result2, 2));
            }

            #endregion

            Console.WriteLine("-------------------------------------");

            #region Bit "NOT" - ~

            {
                byte arg2 = 0b10101010;    // 0xAA

                Console.WriteLine("arg2: {0,8}", Convert.ToString(arg2, 2));

                byte result = (byte)(~arg2);    // явное преобразование типа
                Console.WriteLine("   ~: {0,8}", Convert.ToString(result, 2));

                Console.ForegroundColor = ConsoleColor.Green;

                int k = 20;
                Console.WriteLine("   k: {0,3} - {1,32}", k, Convert.ToString(k, 2));
                Console.WriteLine("  -k: {0,3} - {1,32}", -k, Convert.ToString(-k, 2));

                int kNeg = ~k + 1;
                Console.WriteLine("kNeg: {0,3} - {1,32}", -k, Convert.ToString(kNeg, 2));
            }

            #endregion

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("-------------------------------------");

            const byte MASK01 = 0b00000001;
            const byte MASK02 = 0b00000010;
            const byte MASK03 = 0b00000100;
            const byte MASK04 = 0b00001000;

            byte val = 0;    // 0b00000000

            Console.WriteLine("val: {0,8}", Convert.ToString(val, 2));

            // возведение флагов
            // 3й 
            val = (byte)(val | MASK03);
            Console.WriteLine("val: {0,8}", Convert.ToString(val, 2));
            // 2й 
            val = (byte)(val | MASK02);
            Console.WriteLine("val: {0,8}", Convert.ToString(val, 2));
            // 4й 
            val = (byte)(val | MASK04);
            Console.WriteLine("val: {0,8}", Convert.ToString(val, 2));

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("-------------------------------------");
            // проверка состояния флагов
            if ((val & MASK02) > 0)
            {
                Console.WriteLine("Second flag is 1");
            }
            else
            {
                Console.WriteLine("Second flag is 0");
            }
            if ((val & MASK01) > 0)
            {
                Console.WriteLine("First flag is 1");
            }
            else
            {
                Console.WriteLine("First flag is 0");
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("-------------------------------------");
            // сбрасывание флагов
            // 3й 
            val = (byte)(val & (~MASK03));
            Console.WriteLine("val: {0,8}", Convert.ToString(val, 2));
            // 2й 
            val = (byte)(val & (~MASK02));
            Console.WriteLine("val: {0,8}", Convert.ToString(val, 2));
            // 4й 
            val = (byte)(val & (~MASK04));
            Console.WriteLine("val: {0,8}", Convert.ToString(val, 2));

            int a = 10;
            int b = 3;

            //double res = (double)a / b;
            double res = 1.0 * a / b;

            #region XOR for passwords

            string pwd = "asdыфв123!!+№";

            const ushort PWD_MASK = 0x1A2B;

            string pwd_ = "";

            for (int i = 0; i < pwd.Length; i++)
            {
                pwd_ = pwd_ + (char)((ushort)pwd[i] ^ PWD_MASK);
            }

            Console.WriteLine("  pwd: {0}", pwd);
            Console.WriteLine(" pwd_: {0}", pwd_);

            string pwd__ = "";

            for (int i = 0; i < pwd_.Length; i++)
            {
                pwd__ = pwd__ + (char)((ushort)pwd_[i] ^ PWD_MASK);
            }

            Console.WriteLine("pwd__: {0}", pwd__);

            #endregion

            Console.ReadKey();
        }
    }
}
