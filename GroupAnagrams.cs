using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPractices
{
    /*
     * Given an array of strings strs, group the anagrams together. You can return the answer in any order.
        An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, 
        typically using all the original letters exactly once.

        Example 1:
        Input: strs = ["eat","tea","tan","ate","nat","bat"]
        Output: [["bat"],["nat","tan"],["ate","eat","tea"]]

        Example 2:
        Input: strs = [""]
        Output: [[""]]

        Example 3:
        Input: strs = ["a"]
        Output: [["a"]]
     */
    /*
     * Time:O(m.nlogn) O(m*n)
     * Space: O(m * n * 26)
     * Problem: Looking for anagrams and put them in the group.
     */
    public class GroupAnagrams
    {
        public IList<IList<string>> GrAnagrams(string[] strs)
        {
            //Create an empty dictionary called 'anagrams' to store anagram groups.
            Dictionary<string, List<string>> GAnagrams = new Dictionary<string, List<string>>();

            //Iterate through each string in the 'strs' array.
            foreach (string s in strs)
            {
                //Sort the characters in the string alphabetically.
                //This will give you a unique representation for each anagram group.
                char[] ChArray= s.ToCharArray();

                Array.Sort(ChArray);

                //Check if the sorted string is in the 'anagrams' dictionary:
                //If it is, append the original string to the corresponding list of anagrams.
                //If it isn't, create a new key in the 'anagrams' dictionary with
                //the sorted string and set its value to a list containing the original string.
                string SortedStr = new string(ChArray);

                if(GAnagrams.ContainsKey(SortedStr))
                {
                    GAnagrams[SortedStr].Add(s);
                }
                else
                {
                    GAnagrams[SortedStr] = new List<string> { s};
                }
            }

            //After iterating through all strings, the 'anagrams' dictionary will
            //contain groups of anagrams. Convert the dictionary values to a list and return it.
            return new List<IList<string>>(GAnagrams.Values);
        }
    }
}
