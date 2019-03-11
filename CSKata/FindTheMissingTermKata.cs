using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSKata
{
    public class FindTheMissingTermKata
    {
        public static int FindMissing(List<int> list)
        {
            int CommonDifference = list[1] - list[0];
            for (int i = 1; i < list.Count - 1; i++)
            {
                int diff = list[i + 1] - list[i];

                if (diff < CommonDifference)
                {
                    return list[i - 1] + diff;
                }

                if (diff > CommonDifference)
                {
                    return list[i] + CommonDifference;
                }
            }

            return 0;
        }
    }
}
