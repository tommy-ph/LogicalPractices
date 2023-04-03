using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPractices
{
    public class TwoSum
    {
        /* Description:
            Given an array of integers, return indices of the two numbers such that they add
            up to a specific target.
            You may assume that each input would have exactly one solution, and you may not
            use the same element twice.
            Example:
            Given nums = [2, 7, 11, 15], target = 9,
            Because nums[0] + nums[1] = 2 + 7 = 9,
            return [0, 1].
         */
        /// <summary>
        /// Using a Dictionary: Time Complexity: O(n), Space complexity: O(n)
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns>integer array of indices</returns>
        public static int[] ReturnTwoSum(int[] nums, int target)
        {
            //Declarations
            int arrayLength = nums.Length;
            Dictionary <int, int> map = new Dictionary<int, int>();
            //Validations
            if(nums == null || arrayLength < 2)
            {
                return Array.Empty<int>();
            }
            //Logic
            for(int i = 0; i < arrayLength; i++)
            {
                int firstNumber = nums[i];
                int secondNumber = target - firstNumber;
                if(map.TryGetValue(secondNumber, out int index))
                {
                    return new[] { index, i }; 
                }
                map[firstNumber] = i;
            }
            return Array.Empty<int>();
        }
    }
}
