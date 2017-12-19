using System;
using System.Collections;

namespace Pemrog_Visual_2.BAB5
{
    class ArrayList1
    {
        public static void Main()
        {
            ArrayList arryList1 = new ArrayList();
            arryList1.Add("Valentino Rossi");
            arryList1.Add(46);
            ArrayList arryList2 = new ArrayList();
            arryList2.Add(45);
            arryList2.Add(44);
            arryList1.AddRange(arryList2);
            for (int i = 0; i < arryList1.Count; i++)
            {
                Console.WriteLine(arryList1[i]);
            }
            Console.ReadKey();
        }
    }
}
