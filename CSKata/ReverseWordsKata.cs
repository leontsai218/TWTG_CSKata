using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSKata
{
    public class ReverseWordsKata
    {
        public static string ReverseWords(string str)
        {
            return string.Join(" ", str.Split(' ').Select(w => new string(w.Reverse().ToArray())));
        }
    }
}
