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
            int[] arrayOne = { 1, 2, 3, 4, 5 };
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
