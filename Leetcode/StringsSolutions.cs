using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class StringsSolutions
    {
        public static string LongestCommonPrefix(string[] arr)
        {
            if (arr.Length == 0 || arr.Contains(""))
            {
                return "";
            }
            string firstWord = arr[0];
            var firstWordLenght = firstWord.Length;
            int commonPrefix = int.MaxValue;


            foreach (string word in arr.Skip(0))
            {
                int curentWordLengh = 0;
                int shorterWord = Math.Min(firstWordLenght, word.Length);
                for (var letter = 0; letter < shorterWord; letter++)
                {
                    if (firstWord[letter] == word[letter])
                    {
                        curentWordLengh++;
                    }
                    else
                        break;

                }
                commonPrefix = Math.Min(curentWordLengh, commonPrefix);
            }
            return firstWord.Substring(0, commonPrefix);
        }
    }
}
