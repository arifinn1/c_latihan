using System;
using System.Collections;

namespace Pemrog_Visual_2.BAB5
{
    class SortedList4
    {
        public static void Main()
        {
            SortedList sortedList2 = new SortedList();
            sortedList2.Add("satu", 1);
            sortedList2.Add("dua", 2);
            sortedList2.Add("tiga", 3);
            sortedList2.Add("empat", 4);
            sortedList2.Remove("satu");
            sortedList2.RemoveAt(0);
            foreach (DictionaryEntry kvp in sortedList2)
            {
                Console.WriteLine("key: {0}, value: {1}", kvp.Key, kvp.Value);
            }
            Console.ReadKey();
        }
    }
}
