using System;

namespace Pemrog_Visual_2.BAB4
{
    class While2
    {
        public static void Main()
        {
            int i = 0;
            while (true)
            {
                Console.WriteLine(i);
                i++;
                if (i > 10)
                    break;
            }
            Console.ReadLine();
        }
    }
}
