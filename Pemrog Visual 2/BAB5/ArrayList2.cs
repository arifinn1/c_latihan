using System;
using System.Collections;

namespace Pemrog_Visual_2.BAB5
{
    class ArrayList2
    {
        public static void Main()
        {
            ArrayList myArryList = new ArrayList();
            myArryList.Add("Satu");
            myArryList.Add("Dua");
            myArryList.Add(3);
            myArryList.Add(4.5f);

            string firstElement = (string)myArryList[0];
            Console.WriteLine(firstElement);
            //Console.WriteLine(myArryList[3]);

            string secondElement = (string)myArryList[1];
            Console.WriteLine(secondElement);

            int thirdElement = (int)myArryList[2];
            Console.WriteLine(thirdElement);

            float fourthElement = (float)myArryList[3];
            Console.WriteLine(fourthElement);

            var firstElement2 = myArryList[0];
            Console.WriteLine(firstElement2);

            Console.ReadKey();
        }
    }
}
