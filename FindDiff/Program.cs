using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finddiff
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOne = { 1, 2, 3, 4, 5, 6, 7, 9, 10, 12, 14, 16, 18, 20 };
            var results = LookUpArr(arrayOne);
            foreach (var item in results)
                Console.WriteLine($"Number [{item}]");

            Console.ReadLine();
        }

        static List<Tuple<int, int>> LookUpArr(int[] arrayOne)
        {
            var listNumber = new List<Tuple<int, int>>();
            var arrayTwo = arrayOne;
            int countIndexLoop = 0;
            loopAgain:
            foreach (var item in arrayOne)
            {
                var checkNumberAgainsArray = arrayTwo[countIndexLoop];
                if (checkNumberAgainsArray + 2 == item)
                    listNumber.Add(new Tuple<int, int>(checkNumberAgainsArray, item));
            }
            countIndexLoop++;

            if (countIndexLoop != arrayTwo.Count())
                goto loopAgain;
            else
                return listNumber;
        }
    }
}
