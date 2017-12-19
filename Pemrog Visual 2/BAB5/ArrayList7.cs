using System;
using System.Collections;

namespace Pemrog_Visual_2.BAB5
{
    class ArrayList7
    {
        public static void Main()
        {
            ArrayList arryList1 = new ArrayList();
            arryList1.Add(100);
            arryList1.Add(200);
            arryList1.Add(300);

            arryList1.RemoveAt(1);

            foreach (var item in arryList1)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
