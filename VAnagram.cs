using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPractices
{
    public class VAnagram
    {
        /*
         * Given two strings s and t, return true if t is an anagram of s, and false otherwise.

            An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, 
            typically using all the original letters exactly once.
            
            Example 1:
            Input: s = "anagram", t = "nagaram"
            Output: true

            Example 2:
            Input: s = "rat", t = "car"
            Output: false
         */
        /*
         * HashMap will take extra memory
         * Sorting: take less memory
         * Problem: Two string are considered anagrams if they have the same characters with the same freuency
         * Check both lists if they are anagram and the same amout of the element and length
         * 
         */
        public bool IsAnagram(string s, string t)
        {
            //First, check if the lengths of the two strings are equal.
            //If they are not equal, they can't be anagrams, so we return false.
            if (s.Length != t.Length)
            { 
                return false; 
            }

            //create a Dictionary<char, int> named charCount to store the frequency of each
            //character in the strings.The key is the character, and the value is the frequency of the character.
            Dictionary<char, int> CharCount = new Dictionary<char, int>();

            //We loop through the characters of both strings s and t. For each character in string s,
            //we increment its count in the charCount dictionary. For each character in string t,
            //we decrement its count in the charCount dictionary. We also convert each character to
            //lowercase using char.ToLower() to handle both uppercase and lowercase characters.
            
            for (int i = 0; i < s.Length; i++)
            {
                char SCharacter = char.ToLower(s[i]);
                char TCharacter = char.ToLower(t[i]);

                if(CharCount.ContainsKey(SCharacter))
                {
                    //When we increment the count for a character in string s,
                    //we are keeping track of how many times that character appears in s.
                    CharCount[SCharacter]++;
                }
                else
                {
                    CharCount[SCharacter] = 1;
                }
                //When we decrement the count for a character in string t, we are "canceling out"
                //the count of that character in s. If the character
                //appears the same number of times in both strings, the count should be zero after processing both strings.
                if (CharCount.ContainsKey(TCharacter))
                {
                    CharCount[TCharacter]--;
                }
                else
                {
                    CharCount[TCharacter] = -1;
                }
            }
            //After looping through both strings, if the count of each character in the charCount dictionary is zero,
            //it means both strings have the same characters with the same frequencies, and thus they are anagrams.
            //If any count is not zero, it means the character frequencies are different, and the strings are not
            //anagrams.
            foreach (int count in CharCount.Values)
            {
                if(count != 0)
                {
                    return false;
                }
            }

            return true;

        }
    }
}
