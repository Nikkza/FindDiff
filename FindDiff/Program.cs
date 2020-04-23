using System;
using System.Collections.Generic;
using System.Linq;

namespace Finddiff
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOne = { 1, 2, 3, 4, 5 };
            var results = LookUpArr(arrayOne);
            var inlineResults = string.Join(",", results);
            Console.WriteLine($" Numbers {inlineResults}");
            Console.ReadLine();
        }

        static List<Tuple<int, int>> LookUpArr(int[] arrayOne)
        {
            var listNumber = new List<Tuple<int, int>>();
            var arrayTwo = arrayOne;
            int countIndexLoop = 0;
            while (countIndexLoop != arrayTwo.Count())
            {
                foreach (var item in arrayOne)
                {
                    var checkNumberAgainstArray = arrayTwo[countIndexLoop];
                    if (checkNumberAgainstArray + 2 == item)
                        listNumber.Add(new Tuple<int, int>(checkNumberAgainstArray, item));
                }
                countIndexLoop++;
            }
            return listNumber;
        }
    }
}
