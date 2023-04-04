using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPractices
{
    /*
     * Given a string, find the length of the longest substring without repeating
    characters.
    Example 1:
    Input: "abcabcbb"
    Output: 3
    Explanation: The answer is "abc", with the length of 3.
    Example 2:
    Input: "bbbbb"
    Output: 1
    Explanation: The answer is "b", with the length of 1.
    Example 3:
    Input: "pwwkew"
    Output: 3
    Explanation: The answer is "wke", with the length of 3.

    Note that the answer must be a substring, "pwke" is a subsequence

    and not a substring.
     */
    /*
     * Define the problem: Count a list av character without repeating the same character 
     *            - Define the objects: 
     *            - Need to compair the first character and the second character, if they're
     *            the same or not, 
     *            - then remove the same charater and if Not, 
     *            - then count them and 
     *            - after that retore them. 
     *            : Show the numbers of characters.
     *            - Find the element where it store and display them
     * Look through element
     * Check if element
     * Start looking for the rest
     * Determine
     * Store
     */
    public class SubWithoutRepCharacter
    {
        public static int CountStringWithoutRepeating(string word)
        {
            string testChar = "";

            // Result
            int maxLength = -1;

            // Return zero if string is empty
            if(word.Length ==0)
            {
                return 0;
            }
            else if (word.Length ==1)
            {
                return 1;
            }
            foreach(char w in word.ToCharArray())
            {
                string current = w + "";
                //If string already contains the character
                //then substring after rpeating character
                if(testChar.Contains(current))
                {
                    testChar = testChar.Substring(testChar.IndexOf(current) + 1);
                }
                testChar = testChar + w;
                maxLength = Math.Max(testChar.Length, maxLength);
            }
            return maxLength;

        }
    }
}
