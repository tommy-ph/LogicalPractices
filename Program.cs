using System;
namespace LogicalPractices
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region TwoSum
            // Brute force: Time Complexity: O(n^2), Space complexity: O(1)
            // ({ 2, 7, 11, 15 }, 9);
            //int[] resultOfTwoSum = TwoSum.ReturnTwoSum(new int[] { 2, 7, 11, 15 }, 9);

            //Console.WriteLine(string.Join(",",resultOfTwoSum));
            #endregion
            #region Longest characters without repeating
            string charaters = "abcabcbb";
            Console.WriteLine("Input" + " " + charaters);
            int CountCharacter = SubWithoutRepCharacter.CountStringWithoutRepeating(charaters);
            Console.WriteLine("Output charaters" + " " + CountCharacter);
            #endregion

        }
    }
}