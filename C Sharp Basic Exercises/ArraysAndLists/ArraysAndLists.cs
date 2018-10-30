using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndLists
{
    class ArraysAndLists
    {
        static void Main(string[] args)
        {
            int[] numArray = new int[5];
            numArray[0] = 5;
            numArray[1] = 2;
            numArray[2] = 10;
            numArray[3] = 200;
            numArray[4] = 5000;

            int[] numArray1 = new int[] { 5, 2, 10, 200, 5000 };

            int[] numArray2 = { 5, 2, 10, 200, 5000 };

            numArray2[5] = 650;

            Console.WriteLine(numArray2[5]);
            Console.ReadLine();

            List<int> intList = new List<int>();
            intList.Add(4);
            intList.Add(10);

            List<string> stringList = new List<string>();
            stringList.Add("hello");
            stringList.Add("ken");

            Console.WriteLine(intList[0]);
            Console.WriteLine(stringList[0]);
            Console.ReadLine();
        }
    }
}
