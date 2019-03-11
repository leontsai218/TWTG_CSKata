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
            int multipleOf3 = 3,
                multipleOf5 = 5;
            while (multipleOf3 < value)
            {
                while (multipleOf3 < multipleOf5)
                {
                    sum += multipleOf3;
                    multipleOf3 += 3;
                }

                if (multipleOf5 < value && multipleOf5 % 3 != 0)
                {
                    sum += multipleOf5;
                }

                multipleOf5 += 5;
            }

            return sum;
        }
    }
}
