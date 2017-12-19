using System;

namespace Pemrog_Visual_2.BAB4
{
    class Array1
    {
        public static void Main()
        {
            int[] intArray = new int[5] { 10, 20, 30, 40, 50 };
            string[] strArray = { "One", "Two", "Three" };
            for (int i = 0; i < intArray.Length; i++)
                Console.WriteLine(intArray[i]);
            for (int i = 0; i < strArray.Length; i++)
                Console.WriteLine(strArray[i]);
            Console.ReadLine();
        }
    }
}
