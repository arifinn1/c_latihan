using System;

namespace Latihan1.BAB3
{
    class Switch
    {
        static void Switch1()
        {
            int x = 10;
            switch (x)
            {
                case 5:
                    Console.WriteLine("nilai X adalah 5");
                    break;
                case 10:
                    Console.WriteLine("nilai X adalah 10");
                    break;
                default:
                    Console.WriteLine("Tidak diketahui");
                    break;
            }
        }

        static void Switch2()
        {
            string str = "buah";
            switch (str)
            {
                case "apel":
                    Console.Write(" Ini adalah Apel");
                    break;
                case "bayam":
                    Console.Write("Ini adalah Bayam");
                    break;
                case "wortel":
                    Console.Write("Ini adalah Wortel");
                    break;
                case "buah":
                    goto case "apel";
            }
        }

        static void Main()
        {
            Switch2();
            Console.ReadKey();
        }
    }
}
