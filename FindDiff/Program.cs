using System;
using System.Collections.Generic;
using System.Linq;

namespace Finddiff
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOne = { 1, 2, 3, 4, 5,7,9,11,99 };
            var results = LookUpArr(arrayOne);
            var inlineResults = string.Join(",", results);
            Console.WriteLine($" Numbers {inlineResults}");
            Console.ReadLine();
        }

        static List<Tuple<int, int>> LookUpArr(int[] arrayOne)
        {
            var findNumber = new List<Tuple<int, int>>();
            var arrayTwo = arrayOne;
            int countLoop = 0;
            while (countLoop != arrayTwo.Count())
            {
                foreach (var item in arrayOne)
                {
                    var checkNumberAgainstArray = arrayTwo[countLoop];
                    if (checkNumberAgainstArray + 2 == item)
                        findNumber.Add(new Tuple<int, int>(checkNumberAgainstArray, item));
                }
                countLoop++;
            }
            return findNumber;
        }
    }
}
