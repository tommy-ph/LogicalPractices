using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPractices
{
    public class ProdArrayExceptSelf
    {
        /*
         * Given an integer array nums, return an array answer such that answer[i] 
         * is equal to the product of all the elements of nums except nums[i].
            The product of any prefix or suffix of nums is guaranteed to fit in a 32-bit integer.
            You must write an algorithm that runs in O(n) time and without using the division operation.
            Example 1:
            Input: nums = [1,2,3,4]
            Output: [24,12,8,6]
            Example 2:
            Input: nums = [-1,1,0,-3,3]
            Output: [0,0,9,0,0]
         */

        public int[] ProductExcepSelf(int[] nums)
        {
            int[] result = new int[nums.Length];
            int Prefix = 1;
            for(int i = 0; i < nums.Length; i++)
            {
                result[i] = Prefix;
                Prefix *= nums[i];
            }
            int Postfix = 1;
            for(int i = nums.Length -1; i >= 0; i--)
            {
                result[i] *= Postfix;
                Postfix *= nums[i];
            }
            return result;

        }
    }
}
