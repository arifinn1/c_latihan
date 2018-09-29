using System;

namespace Latihan1.BAB3
{
    class If
    {
        static void If1()
        {
            if (true)
            {
                Console.WriteLine("Kondisi ini Benar");
            }
            Console.ReadLine();
        }

        static void If2()
        {
            int i = 10;
            if (i > 5)
            {
                Console.WriteLine("Nilai lebih besar dari 5");
            }
            Console.ReadLine();
        }

        static void IfElse1()
        {
            int a = 5, b = 10;
            if (a > b)
            {
                Console.WriteLine("Nilai a lebih besar dari b");
            }
            else
            {
                Console.WriteLine("Nilai a lebih kecil dari atau sama dengan b");
            }
            Console.ReadLine();
        }

        static void IfElse2()
        {
            int a = 5, b = 10;
            if (a > b)
            {
                Console.WriteLine("Nilai a lebih besar dari b");
            }
            else if (a < b)
            {
                Console.WriteLine("Nilai a lebih dari kecil b");
            }
            else
            {
                Console.WriteLine("Nilai a sama dengan b");
            }

            Console.ReadLine();
        }

        static void IfNested()
        {
            int a = 10;
            if (a > 0)
            {
                if (a <= 10)
                {
                    Console.WriteLine("a adalah bilangan positif <= 10");
                }
                else
                {
                    Console.WriteLine("a adalah bilangan positif > 10");
                }
            }
            else
            {
                Console.WriteLine("a adalah bilangan negativ");
            }
            Console.ReadKey();
        }

        public static void Main()
        {
            IfNested();
        }
    }
}
