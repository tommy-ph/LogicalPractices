using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPractices
{
    /*
     * Given an integer array nums, return true if any value appears at least twice in the array, 
     * and return false if every element is distinct.

        Example 1:
        Input: nums = [1,2,3,1]
        Output: true

        Example 2:
        Input: nums = [1,2,3,4]
        Output: false

        Example 3:
        Input: nums = [1,1,1,3,3,4,3,2,4,2]
        Output: true
     */
    /* Brut-Force: check every numbers and campare them,
     * Sorting O(nlogn): Take an array and sort it. Iterate through the array onece, 
     * but take more time complexity, but no Space
     * HashSet- will use extra memory and prevent duplicate elements: 
     * Use to insert the element inside the hashSet and allow us to check. 
     * Can ask the hashMap for a certain value exist, if the value does not exist then add to the map, 
     * if value duplicate then return true
     * Time complexity
     * O(n2)
     * Space Complexity
     * O(1)
     */
    public class ContainsDuplicate
    {
        public bool ConDuplicate(int[] nums)
        {
            HashSet<int> hashset = new HashSet<int>();
            
            for (int i = 0; i < nums.Length; i++)
            {
                if (hashset.Contains(nums[i]))
                {
                    return true;
                }
                else
                {
                    hashset.Add(nums[i]);
                }
            }
            return false;
        }
    }
}
