using System;
using System.Collections;

namespace Pemrog_Visual_2.BAB5
{
    class SortedList1
    {
        public static void Main()
        {
            SortedList sortedList = new SortedList();
            sortedList.Add("satu", 1);
            sortedList.Add("dua", 2);
            sortedList.Add("tiga", 3);
            sortedList.Add("empat", "Empat");

            int i = (int)sortedList["satu"];
            int j = (int)sortedList["dua"];

            string str = (string)sortedList["empat"];

            Console.WriteLine(i);
            Console.WriteLine(j);
            Console.WriteLine(str);

            Console.ReadKey();
        }
    }
}
