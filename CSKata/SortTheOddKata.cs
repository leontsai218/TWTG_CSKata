using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSKata
{
    public class SortTheOddKata
    {
        public static int[] SortArray(int[] array)
        {
            if (array.Length > 0)
            {
                var sortedNums = new List<int>();
                var odds = new Queue<int>(array.Where(x => x % 2 == 1).OrderBy(x => x));

                foreach(int n in array)
                {
                    sortedNums.Add(n % 2 == 0 ? n : odds.Dequeue());
                }

                return sortedNums.ToArray();
            }
            return array;
        }
    }
}
