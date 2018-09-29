using System;
using System.Collections;

namespace Latihan1.BAB5
{
    class ArrList
    {
        static void ArrList1()
        {
            ArrayList arr1 = new ArrayList();
            arr1.Add("Valentino Rossi");
            arr1.Add(46);

            ArrayList arr2 = new ArrayList();
            arr2.Add(45);
            arr2.Add(44);

            arr1.AddRange(arr2);

            for (int i = 0; i < arr1.Count; i++) Console.WriteLine(arr1[i]);
        }

        static void ArrList2()
        {
            ArrayList arr1 = new ArrayList();
            arr1.Add("Satu");
            arr1.Add("Dua");
            arr1.Add(3);
            arr1.Add(4.5f);

            string firstElement = (string)arr1[0];
            Console.WriteLine(firstElement);

            string secondElement = (string)arr1[1];
            Console.WriteLine(secondElement);

            int thirdElement = (int)arr1[2];
            Console.WriteLine(thirdElement);

            float fourthElement = (float)arr1[3];
            Console.WriteLine(fourthElement);

            var firstElement2 = arr1[0];
            Console.WriteLine(firstElement2);
        }

        static void ArrList3()
        {
            ArrayList arr1 = new ArrayList();
            arr1.Add("Satu");
            arr1.Add("Two");
            arr1.Add(3);
            arr1.Add(4.5);

            Console.WriteLine("Menggunakan foreach loop");
            foreach (var val in arr1) Console.WriteLine(val);

            Console.WriteLine("Menggunakan for loop");
            for (int i = 0; i < arr1.Count; i++) Console.WriteLine(arr1[i]);
        }

        static void ArrInsert()
        {
            ArrayList arr1 = new ArrayList();
            arr1.Add(1);
            arr1.Add("Dua");
            arr1.Add(3);
            arr1.Add(4.5);

            arr1.Insert(1, "Item Kedua");
            arr1.Insert(2, 100);

            foreach (var val in arr1) Console.WriteLine(val);
        }

        static void ArrInsertR()
        {
            ArrayList arr1 = new ArrayList();
            arr1.Add(100);
            arr1.Add(200);

            ArrayList arr2 = new ArrayList();
            arr2.Add(10);
            arr2.Add(20);
            arr2.Add(30);

            arr2.InsertRange(2, arr1);

            foreach (var item in arr2) Console.WriteLine(item);
        }

        static void ArrRem()
        {
            ArrayList arr1 = new ArrayList();
            arr1.Add(100);
            arr1.Add(100);
            arr1.Add(200);
            arr1.Add(300);

            foreach (var item in arr1) Console.WriteLine(item);

            arr1.Remove(100);

            foreach (var item in arr1) Console.WriteLine(item);
        }

        static void ArrRemAt()
        {
            ArrayList arr1 = new ArrayList();
            arr1.Add(100);
            arr1.Add(200);
            arr1.Add(300);

            arr1.RemoveAt(1);

            foreach (var item in arr1) Console.WriteLine(item);
        }

        static void ArrRemRang()
        {
            ArrayList arr1 = new ArrayList();
            arr1.Add(100);
            arr1.Add(200);
            arr1.Add(300);

            arr1.RemoveRange(0, 2);

            foreach (var item in arr1) Console.WriteLine(item);
        }

        static void ArrSort()
        {
            ArrayList arr1 = new ArrayList();
            arr1.Add(300);
            arr1.Add(200);
            arr1.Add(100);
            arr1.Add(500);
            arr1.Add(400);

            Console.WriteLine("Original :");
            foreach (var item in arr1) Console.WriteLine(item);

            arr1.Reverse();

            Console.WriteLine("Reverse Order :");
            foreach (var item in arr1) Console.WriteLine(item);

            arr1.Sort();
            //arr1.Reverse();

            Console.WriteLine("Ascending Order :");
            foreach (var item in arr1) Console.WriteLine(item);
        }

        static void Main()
        {
            ArrRem();
            Console.ReadLine();
        }
    }
}
