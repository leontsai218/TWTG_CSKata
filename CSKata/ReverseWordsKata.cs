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
            return string.Join(" ", str.Split(' ').Select(w => ReverseWord(w)));
        }

        private static string ReverseWord(string str)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = str.Length - 1; i >= 0; i--)
            {
                sb.Append(str[i]);
            }
            return sb.ToString();
        }
    }
}
