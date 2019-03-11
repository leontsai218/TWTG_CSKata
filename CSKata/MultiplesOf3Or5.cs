using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSKata
{
    public class MultiplesOf3Or5
    {
        public static int Solution(int value)
        {
            int sum = 0;

            for (int multipleOf3 = 3; multipleOf3 < value; multipleOf3 += 3)
            {
                sum += multipleOf3;
            }

            for (int multipleOf5 = 5; multipleOf5 < value; multipleOf5 += 5)
            {
                if (multipleOf5 % 3 != 0)
                {
                    sum += multipleOf5;
                }
            }

            return sum;
        }
    }
}
