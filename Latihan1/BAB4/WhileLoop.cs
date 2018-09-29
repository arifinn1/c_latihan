using System;

namespace Latihan1.BAB4
{
    class WhileLoop
    {
        static void While1()
        {
            int i = 0;

            while (i < 10)
            {
                Console.WriteLine(i);
                i++;
            }
        }

        static void While2()
        {
            int i = 0;

            while (true)
            {
                Console.WriteLine(i);
                i++;

                if (i > 10)
                    break;
            }
        }

        static void DoWhile1()
        {
            int i = 0;

            do
            {
                Console.WriteLine(i);
                i++;
            } while (false);
        }

        static void DoWhile2()
        {
            int i = 0;

            do
            {
                Console.WriteLine(i);
                i++;
            } while (i < 10);
        }

        static void Main()
        {
            DoWhile2();
            Console.ReadLine();
        }
    }
}
