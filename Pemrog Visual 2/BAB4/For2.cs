using System;

namespace Pemrog_Visual_2.BAB4
{
    class For2
    {
        public static void Main()
        {
            int i = 0;
            for (; ; )
            {
                if (i < 10)
                {
                    Console.WriteLine(i);
                    i++;
                }
                else
                    break;
            }
            Console.ReadLine();
        }
    }
}
