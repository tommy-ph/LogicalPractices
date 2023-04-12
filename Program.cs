using System;
namespace LogicalPractices
{
    public class Program
    {
        public static void Main(string[] args)
        {
            #region TwoSum
            // Brute force: Time Complexity: O(n^2), Space complexity: O(1)
            // ({ 2, 7, 11, 15 }, 9);
            //int[] resultOfTwoSum = TwoSum.ReturnTwoSum(new int[] { 2, 7, 11, 15 }, 9);

            //Console.WriteLine(string.Join(",",resultOfTwoSum));
            #endregion
            #region Longest characters without repeating
            //string charaters = "abcabcbb";
            //Console.WriteLine("Input" + " " + charaters);
            //int CountCharacter = SubWithoutRepCharacter.CountStringWithoutRepeating(charaters);
            //Console.WriteLine("Output charaters" + " " + CountCharacter);
            #endregion
            #region Sorted two Arrays
            ////int[] num1 = { 1, 3 };
            ////int[] num2 = {2};
            //int[] num1 = { 1, 2 };
            //int[] num2 = { 3, 4 };
            ////int[] MergingArrays = SortedArrays.FindSortedArrayMedian(num1, num2);
            //double median = SortedArrays.FindSortedArrayMedian(num1, num2);
            //Console.WriteLine(median);
            ////for(int i = 0; i< MergingArrays.Length; i++)
            ////{
            ////    Console.WriteLine(MergingArrays[i]);
            ////}

            #endregion
            #region PalindromicSubstring
            //PalindromicSubstring palindromicSubstring= new PalindromicSubstring();
            //string input = "babad";
            //string output = palindromicSubstring.FindLongestPalindrome(input);
            //Console.WriteLine(output);
            #endregion
            #region ZigZag Conversion
            //ZigZagConversion ZZC = new ZigZagConversion();
            //string InPut = "PAYPALISHIRING";
            //int numRows = 4;

            //string Result = ZZC.ConvertStringToRowNumber(InPut,numRows);
            //Console.WriteLine(Result);
            #endregion

            #region Reverse Integer
            //ReverseInteger reverseInteger = new ReverseInteger();
            //int x = 1230;
            //int Result = reverseInteger.Reverse(x);
            //Console.WriteLine(Result);
            #endregion
        }
    }
}