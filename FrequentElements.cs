using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPractices
{
    /*
     * Given an integer array nums and an integer k, return the k most frequent elements. 
     * You may return the answer in any order.
        Example 1:
        Input: nums = [1,1,1,2,2,3], k = 2
        Output: [1,2]
        Example 2:
        Input: nums = [1], k = 1
        Output: [1]
     */
    /*
     * Heap
     * Linear time
     * Burket Sort
     */
    public class FrequentElements
    {
        public int[] TopKFrequent(int[] nums, int k)
        {
            
            //Initialize a Dictionary to store the frequency of each element
            var FreqMap = new Dictionary<int, int>();

            //Iterate through the input array and populate the frequency 
            foreach (int n in nums)
            {
                if(FreqMap.ContainsKey(n))
                {
                    FreqMap[n]++;
                }
                else
                {
                    FreqMap[n] = 1;
                }
            }

            //Initialize an array of lists to act as buckets
            List<int>[] KeyInsideBuckets = new List<int>[nums.Length + 1];

            //Iterate through the frequency map and put the elements into
            //the corresponding frequency buckets
            foreach (int key in FreqMap.Keys)
            {
                int Frequency = FreqMap[key];
                if (KeyInsideBuckets[Frequency] == null)
                {
                    KeyInsideBuckets[Frequency] = new List<int>();
                }
                KeyInsideBuckets[Frequency].Add(key);
            }

            //Iterate through the buckets in reverse order and collect the top K frequent elements
            var CountKFreq = new List<int>();
            for(int i = KeyInsideBuckets.Length -1; i >= 0 && CountKFreq.Count < k; i--)
            {
                if (KeyInsideBuckets[i] != null)
                {
                    CountKFreq.AddRange(KeyInsideBuckets[i]);
                }
            }
            return CountKFreq.ToArray();
        }
    }
}
