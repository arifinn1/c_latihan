using System;
using System.Collections;

namespace Pemrog_Visual_2.BAB5
{
    class ArrayList9
    {
        public static void Main()
        {
            ArrayList arryList1 = new ArrayList();
            arryList1.Add(300);
            arryList1.Add(200);
            arryList1.Add(100);
            arryList1.Add(500);
            arryList1.Add(400);

            Console.WriteLine("Original :");
            foreach (var item in arryList1)
            {
                Console.WriteLine(item);
            }

            arryList1.Reverse();
            Console.WriteLine("Reverse Order:");
            foreach (var item in arryList1)
            {
                Console.WriteLine(item);
            }

            arryList1.Sort();
            Console.WriteLine("Ascending Order:");
            foreach (var item in arryList1)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
