using System;
using System.Collections;

namespace Pemrog_Visual_2.BAB5
{
    class ArrayList3
    {
        public static void Main()
        {
            ArrayList myArryList = new ArrayList();
            myArryList.Add("Satu");
            myArryList.Add("Two");
            myArryList.Add(3);
            myArryList.Add(4.5);

            Console.WriteLine("Menggunakan for loop");
            foreach (var val in myArryList)
            {
                Console.WriteLine(val);
            }

            Console.WriteLine("Menggunakan foreach loop");
            for (int i = 0; i < myArryList.Count; i++)
            {
                Console.WriteLine(myArryList[i]);
            }

            Console.ReadKey();
        }
    }
}
