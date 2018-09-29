using System;
using System.Collections;

namespace Latihan1.BAB5
{
    class ArrSList
    {
        static void ArrAdd1()
        {
            SortedList sarr = new SortedList();
            sarr.Add("satu", 1);
            sarr.Add("dua", 2);
            sarr.Add("tiga", 3);
            sarr.Add("empat", "Empat");

            int i = (int)sarr["satu"];
            int j = (int)sarr["dua"];
            string str = (string)sarr["empat"];

            Console.WriteLine(i);
            Console.WriteLine(j);
            Console.WriteLine(str);
        }

        static void ArrAdd2()
        {
            SortedList sarr = new SortedList();
            sarr.Add("satu", 1);
            sarr.Add("dua", 2);
            sarr.Add("tiga", 3);
            sarr.Add("empat", 4);

            for (int i = 0; i < sarr.Count; i++)
                Console.WriteLine("key: {0}, Nilai : {1}", sarr.GetKey(i), sarr.GetByIndex(i));
        }

        static void ArrAdd3()
        {
            SortedList sarr = new SortedList();
            sarr.Add("satu", 1);
            sarr.Add("dua", 2);
            sarr.Add("tiga", 3);
            sarr.Add("empat", 4);

            foreach (DictionaryEntry kvp in sarr)
                Console.WriteLine("key = {0}, value = {1}", kvp.Key, kvp.Value);
        }

        static void ArrRem()
        {
            SortedList sarr = new SortedList();
            sarr.Add("satu", 1);
            sarr.Add("dua", 2);
            sarr.Add("tiga", 3);
            sarr.Add("empat", 4);

            sarr.Remove("satu");
            sarr.RemoveAt(0);

            foreach (DictionaryEntry kvp in sarr)
                Console.WriteLine("key = {0}, value = {1}", kvp.Key, kvp.Value);
        }

        static void Main()
        {
            ArrAdd2();
            Console.ReadLine();
        }
    }
}
