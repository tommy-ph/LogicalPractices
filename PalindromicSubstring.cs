using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPractices
{
    /*
     * Given a string s, return the longest palindromic substring in s.
        Example 1:
        Input: s = "babad"
        Output: "bab"
        Explanation: "aba" is also a valid answer.

        Example 2:
        Input: s = "cbbd"
        Output: "bb"
     */
    /* Find if the string is palindrom or not
     * 
     */
    public class PalindromicSubstring
    {
        public string FindLongestPalindrome(string s)
        {
            //Chech the string if it's empty
            if(string.IsNullOrEmpty(s))
            {
                return "";
            }

            string checkedString = CheckString(s);
            int n = checkedString.Length;
            int[] palindromeLenght = new int[n];
            int indexStart = 0;
            int indexEnd = 0;
            int maxPalindromeLenght = 0;
            int maxPalindromeCenter = 0;

            for(int i =0; i < n -1; i++)
            {
                int sameChar = 2 * indexStart - i;

                if(indexEnd > i)
                {
                    palindromeLenght[i] = Math.Min(indexEnd - i, palindromeLenght[sameChar]);
                }

                // Attempt to expand the palindrome around the center i
                while (i + palindromeLenght[i]+1 < n && i - palindromeLenght[i] -1 >= 0 && checkedString[ i + palindromeLenght[i] +1] == checkedString[i - palindromeLenght[i] - 1])
                {
                    palindromeLenght[i]++;
                }

                // Update the IndexStart and IndexEnd if the palindrome Started at i expands beyond Ended
                if(i + palindromeLenght[i] > indexEnd)
                {
                    indexStart= i;
                    indexEnd = i + palindromeLenght[i];
                }

                // Update the max palindrome length and indexStart if necessary
                if (palindromeLenght[i] > maxPalindromeLenght)
                {
                    maxPalindromeLenght = palindromeLenght[i];
                    maxPalindromeCenter = i;
                }
            }
            int start = (maxPalindromeCenter - maxPalindromeLenght) / 2;
            return s.Substring(start, maxPalindromeLenght);
        }

        private string CheckString(string s)
        {
            int n = s.Length;
            if(n==0)
            {
                return "^$";
            }

            string result = "^";
            for(int i = 0; i < n; i++)
            {
                result+= "#" + s[i];
            }
            result += "#$";

            return result;
        }
    }
}
