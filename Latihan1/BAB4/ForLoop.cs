using System;

namespace Latihan1.BAB4
{
    class ForLoop
    {
        static void For1()
        {
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine(i);
            }
        }

        static void For2()
        {
            int i = 0;

            for ( ; ; )
            {
                if (i < 10)
                {
                    Console.WriteLine(i);
                    i++;
                }
                else
                    break;
            }
        }

        static void Main()
        {
            For2();
            Console.ReadLine();
        }
    }
}
