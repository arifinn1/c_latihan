using System;

namespace Latihan1.BAB4
{
    class Array
    {
        static void Array1()
        {
            int[] intArray = new int[5] { 10, 20, 30, 40, 50 };
            string[] strArray = { "One", "Two", "Three" };

            for (int i = 0; i < intArray.Length; i++)
                Console.WriteLine(intArray[i]);

            for (int i = 0; i < strArray.Length; i++)
                Console.WriteLine(strArray[i]);
        }

        static void Array2()
        {
            int[,] intArray = new int[3, 2]
                {
                    { 1, 2 },
                    { 3, 4 },
                    { 5, 6 }
                };

            //Console.WriteLine(intArray.GetLength(1));

            foreach (int arr in intArray)
                Console.WriteLine(arr);
        }

        static void Main()
        {
            Array2();
            Console.ReadLine();
        }
    }
}
