using System;

namespace SubsetSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var maxSum = new MaxSum();
            int[] arr = new int[7] { 10, 2, 1, 8, 4, 6, 10 };
            var sum = maxSum.FindSum(arr);
            Console.WriteLine($"Maximal sum: {sum}");
        }
    }
}
