using System;
using System.Collections;

namespace Pemrog_Visual_2.BAB5
{
    class ArrayList5
    {
        public static void Main()
        {
            ArrayList arryList1 = new ArrayList();
            arryList1.Add(100);
            arryList1.Add(200);

            ArrayList arryList2 = new ArrayList();
            arryList2.Add(10);
            arryList2.Add(20);
            arryList2.Add(30);

            arryList2.InsertRange(2, arryList1);

            foreach (var item in arryList2)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
