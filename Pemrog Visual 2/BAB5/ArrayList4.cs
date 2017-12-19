using System;
using System.Collections;

namespace Pemrog_Visual_2.BAB5
{
    class ArrayList4
    {
        public static void Main()
        {
            ArrayList myArryList = new ArrayList();
            myArryList.Add(1);
            myArryList.Add("Dua");
            myArryList.Add(3);
            myArryList.Add(4.5);

            myArryList.Insert(1, "Item Kedua");
            myArryList.Insert(2, 100);

            foreach (var val in myArryList)
            {
                Console.WriteLine(val);
            }

            Console.ReadKey();
        }
    }
}
