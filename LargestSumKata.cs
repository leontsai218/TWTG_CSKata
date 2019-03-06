using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSKata
{
    public static class LargestSumKata
    {
        public static int LargestSum(IEnumerable<int> numbers)
        {
            int maxSum = 0;
            int sum = 0;
            foreach (int n in numbers)
            {
                sum += n;
                if (sum > maxSum)
                {
                    maxSum = sum;
                }
                else if (sum < 0)
                {
                    sum = 0;
                }
            }

            return maxSum;
        }
    }
}
