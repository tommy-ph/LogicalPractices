using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPractices
{
    /*There are two sorted arrays nums1 and nums2 of size m and n respectively.
    Find the median of the two sorted arrays. The overall run time complexity should
    be O(log (m+n)).
    You may assume nums1 and nums2 cannot be both empty.
    Example 1:
    nums1 = [1, 3], nums2 = [2]
    Output: 2.00000
    Explanation: merged array = [1,2,3] and median is 2.
    Example 2:
    Input: nums1 = [1,2], nums2 = [3,4]
    Output: 2.50000
    Explanation: merged array = [1,2,3,4] and median is (2 + 3) / 2 = 2.5.
     */
    /*
     * Define problem: Find the median in (N)*2-array and 
     * run time complexity should be O(log (m+n)).
     * Look through element in the array and sort it in order
     * Check if element
     * Start looking for the rest
     * Determine
     * Store
     */
    public static class SortedArrays
    {
        public static double FindSortedArrayMedian(int[] num1, int[] num2)
        {
            int[] MergingArrays = new int[num1.Length + num2.Length];
            int IndexNum1 = 0;
            int IndexNum2 = 0;
            //Sort array
            for (int i = 0; i < MergingArrays.Length; i++)
            {
                if (IndexNum1 < num1.Length && (IndexNum2 >= num2.Length||num1[IndexNum1] <= num2[IndexNum2]))
                {
                    MergingArrays[i] = num1[IndexNum1];
                    IndexNum1++;
                }
                else { 
                        if (IndexNum2 < num2.Length)
                        {
                            MergingArrays[i] = num2[IndexNum2];
                            IndexNum2++;
                        }
                    }
            }
            //Find the median
            int MedianIndex = MergingArrays.Length/2;

            if(MergingArrays.Length % 2 == 0) 
            {
                // If the length is even, the median is the average of the two middle elements
                return (MergingArrays[MedianIndex -1] + MergingArrays[MedianIndex])/2.0;
            }
            else
            {
                // If the length is odd, the median is the middle element
                return MergingArrays[MedianIndex];
            }
        }
    }

    /*
     * What is sorted Arrays?
     * A sorted array is an array in which the elements are arranged in a specific order, 
     * typically ascending or descending order. Sorting an array makes it easier to search 
     * for specific elements, as well as perform operations such as binary search, 
     * which requires the array to be sorted beforehand.
     * There are several sorting algorithms that can be used to sort an array, 
     * including bubble sort, insertion sort, selection sort, merge sort, and quicksort. 
     * The choice of sorting algorithm depends on the size of the array, the distribution 
     * of the elements, and the desired time and space complexity of the sorting operation.
     * Sorted arrays are commonly used in computer science and programming to solve various 
     * problems, including searching, sorting, and data analysis. They are also used in 
     * database management systems, where indexes are created on sorted columns to 
     * speed up queries and improve performance.
     * 
     * What is run time complexity to be O(log (m+n))?
     * The runtime complexity of O(log(m+n)) is generally associated with algorithms that
     * efficiently search or retrieve elements from a data structure that has two sorted 
     * sequences, each containing m and n elements, respectively.
     * One of the most common algorithms that has this runtime complexity is the binary 
     * search algorithm, which is used to search for a specific element in a sorted 
     * array. The algorithm works by repeatedly dividing the array in half and searching 
     * in the half where the target element might be until the element is found or the 
     * search range is exhausted.
     * In the context of searching in two sorted sequences, the algorithm can be used to 
     * search for a specific element in both sequences simultaneously. To do this, the 
     * algorithm compares the middle element of each sequence and determines which half 
     * of each sequence to search next. By dividing the sequences in half at each step, 
     * the search is performed in O(log(m+n)) time complexity.
     * This runtime complexity is considered very efficient, especially for large input 
     * sizes, since it grows much slower than linear time (O(m+n)) 
     * or quadratic time (O(m*n)) algorithms.
     * 
     * One common example of an algorithm with O(log(m+n)) runtime complexity is the merge
     * step in the merge-sort algorithm, which is used to merge two sorted arrays into a 
     * single sorted array.
     * The merge step works by comparing the first element of each array and selecting the 
     * smaller one to be the next element in the merged array. The algorithm then moves to 
     * the next element in the array from which the smaller element was selected, and 
     * repeats the comparison until all elements have been merged.
     * Since both arrays are already sorted, the algorithm can efficiently determine which 
     * element to select next by comparing the middle element of each array. By dividing 
     * the arrays in half at each step, the merge step can be performed in O(log(m+n)) 
     * time complexity.
     */
}
