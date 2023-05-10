using System;
using System.Text;

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
            #region Contains Dupplicate
            //ContainsDuplicate containsDuplicate = new ContainsDuplicate();
            //int[] nums = new int[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 };
            //bool result =containsDuplicate.ConDuplicate(nums);
            //Console.WriteLine(result);
            #endregion
            #region Valid Anagram
            //VAnagram vAnagram = new VAnagram();
            //string s = "anagram";
            //string t = "nagaram";

            //bool Result = vAnagram.IsAnagram(s, t);
            //Console.WriteLine("-------------Print---------------");
            //Console.WriteLine(Result);

            #region Contains Dupplicate
            //ContainsDuplicate containsDuplicate = new ContainsDuplicate();
            //int[] nums = new int[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 };
            //bool result =containsDuplicate.ConDuplicate(nums);
            //Console.WriteLine(result);
            #endregion

            #region Valid Anagram
            //VAnagram vAnagram = new VAnagram();
            //string s = "anagram";
            //string t = "nagaram";

            //bool Result = vAnagram.IsAnagram(s, t);
            //Console.WriteLine("-------------Print---------------");
            //Console.WriteLine(Result);
            #endregion
            #endregion
            #region Group the anagrams
            //GroupAnagrams groupAnagrams = new GroupAnagrams();
            //string[] Gstrings = { "eat", "tea", "tan", "ate", "nat", "bat" };
            //IList<IList<string>> result= groupAnagrams.GrAnagrams(Gstrings);

            //foreach (IList<string> group in result)
            //{
            //    Console.WriteLine($"[{string.Join(",", group)}]");
            //}
            #endregion
            #region Top K Frequent Elements
            //int[] nums = { 1, 1, 1, 2, 2, 3, 3, 4, 4, 100000 };
            //int k = 2;

            //FrequentElements TopKFreqElements = new FrequentElements();
            //int[] Result = TopKFreqElements.TopKFrequent(nums, k);
            //Console.WriteLine(string.Join(", ", Result));
            #endregion
            #region Product of Array Except Self
            //int[] nums = { 1, 2, 3, 4 };

            //ProdArrayExceptSelf prod = new ProdArrayExceptSelf();

            //int[] output = prod.ProductExcepSelf(nums);

            //StringBuilder sb= new StringBuilder();
            //sb.Append("Output: [");

            //for(int i = 0; i < output.Length; i++)
            //{
            //    sb.Append(output[i]);
            //    if(i < output.Length - 1)
            //    {
            //        sb.Append(",");
            //    }
            //}
            //sb.Append("]");
            //Console.WriteLine(sb.ToString());

            #endregion
            #region Valid Sudoku
            //char[][] board = new char[][]
            //{
            //    new char[] { '5', '3', '.', '.', '7', '.', '.', '.', '.' },
            //    new char[] { '6', '.', '.', '1', '9', '5', '.', '.', '.' },
            //    new char[] { '.', '9', '8', '.', '.', '.', '.', '6', '.' },
            //    new char[] { '8', '.', '.', '.', '6', '.', '.', '.', '3' },
            //    new char[] { '4', '.', '.', '8', '.', '3', '.', '.', '1' },
            //    new char[] { '7', '.', '.', '.', '2', '.', '.', '.', '6' },
            //    new char[] { '.', '6', '.', '.', '.', '.', '2', '8', '.' },
            //    new char[] { '.', '.', '.', '4', '1', '9', '.', '.', '5' },
            //    new char[] { '.', '.', '.', '.', '8', '.', '.', '7', '9' },
            //};

            //ValidSudoku validSudoku = new ValidSudoku();
            //bool isValid = validSudoku.IsValidSudoku(board);

            //validSudoku.DisplaySudokuBoard(board);
            //Console.WriteLine($"\nThe given Sudoku board is {(isValid ? "valid" : "invalid")}");

            #endregion

            #region Encode and Decode Strings
            EncodeDecodeString code = new EncodeDecodeString();
            List<string> output = new List<string> { "lint", "code", "love", "you" };//"we", ";", "say", ":", "yes", "#" 

            string encoded = code.encode(output);
            Console.WriteLine(encoded);

            List<string> expected = code.decode(encoded);
            Console.WriteLine(string.Join(", ", expected));
            #endregion
        }
    }
}