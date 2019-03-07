using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSKata
{
    public class AnagramDetectionKata
    {
        public static bool IsAnagram(string test, string original)
        {
            test = test.ToLower();
            original = original.ToLower();

            var letterPool = new Dictionary<char, int>();
            foreach(var c in original)
            {
                if (letterPool.ContainsKey(c))
                {
                    letterPool[c]++;
                }
                else
                {
                    letterPool.Add(c, 1);
                }
            }

            foreach(var c in test)
            {
                if (letterPool.ContainsKey(c))
                {
                    letterPool[c]--;
                }
            }


            foreach(var letter in letterPool)
            {
                if(letter.Value != 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
