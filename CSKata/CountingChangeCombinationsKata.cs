using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace CSKata
{
    public class CountingChangeCombinationsKata
    {
        public static int CountCombinations(int money, int[] coins)
        {
            var combinationCount = new int[money + 1];
            combinationCount[0] = 1;

            foreach (int coin in coins)
            {
                for (int i = coin; i <= money; i++)
                {
                    combinationCount[i] += combinationCount[i - coin];
                }
            }

            return combinationCount[money];
        }
    }
}
