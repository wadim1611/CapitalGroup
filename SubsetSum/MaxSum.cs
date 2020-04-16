using System;

namespace SubsetSum
{
    public class MaxSum
    {
        /************************************************************************
         * Function to return max sum such that no two elements are adjacent
         * Time Complexity: O(n)
         * Spatial complexity: O(n)
         ************************************************************************/
        public int FindSum(int[] arr)
        {
            if (arr.Length == 0) return 0;
            if (arr.Length == 1) return arr[0];

            int prev_prev = arr[0];
            int prev = Math.Max(arr[0], arr[1]);
            int res = prev;

            for (int i = 3; i <= arr.Length; i++)
            {
                res = Math.Max(prev, prev_prev + arr[i - 1]);
                prev_prev = prev;
                prev = res;
            }

            return res;
        }
    }
}
