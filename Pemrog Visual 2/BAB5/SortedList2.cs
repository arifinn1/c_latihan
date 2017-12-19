using System;
using System.Collections;

namespace Pemrog_Visual_2.BAB5
{
    class SortedList2
    {
        public static void Main()
        {
            SortedList sortedList2 = new SortedList();
            sortedList2.Add("satu", 1);
            sortedList2.Add("dua", 2);
            sortedList2.Add("tiga", 3);
            sortedList2.Add("empat", 4);

            for (int i = 0; i < sortedList2.Count; i++)
            {
                Console.WriteLine("key: {0}, Nilai: {1}", sortedList2.GetKey(i),
                sortedList2.GetByIndex(i));
            }

            Console.ReadKey();
        }
    }
}
