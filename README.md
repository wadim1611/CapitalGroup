# CapitalGroup test task

1. Having a non-empty array of non-negative integers of length N, you need to return the maximum sum of subset of array elements such that you never take any two adjacent elements.

0 <= N <= 10^9

Example 1: input - [1,2,3,1], output - 4. You take the 1st and the 3rd elements

Example 2: input - [2,7,9,3,1], output - 12. You take the 1st, the 3rd and the 5th elements

Example 3: input - [5,1,2,5], output - 10. You take the 1st and the 4th elements

```
public class MaxSum
{
  public int FindSum(int[] arr)
  {
    //Your solution goes here
  }
}
```

2. You have a map of the monitor's pixels where good pixels are marked with '0' and dead pixels are marked with '1'.

Write a code that returns the number of dead pixel groups.

A group is surrounded by good pixels (or monitor edges) and is formed by connecting adjacent dead pixels horizontally or vertically (NOT diagonally).

A group may consist of a single pixel if it satisfies the above condition.

1 <= monitor.Length <= 4320

1 <= monitor[i].Length <= 7680

Example 1: input - ['1','0','1'], output - 5

['0','1','0'],

['1','0','1']

Example 2: input - ['1','1','1'], output - 2

['1','0','0'],

['1','0','1']

```
public class DeadPixels
{
  public int CountGroups(char[][] monitor)
  {
  //Your solution goes here
  }
}
```

3. Please provide time AND spatial complexity of both solutions using big O notation.

Note: when solving these tasks please consider not only the correct solution, but also the performant one.

If possible, check for edge cases and different input sizes.

You may safely assume, that you won't get any corrupted data, no nulls, no sizes over the specified ones. No need to validate the input data.

- You don't have to provide tests along with the solution itself (but its ok if you write some).
- Do not break the given signatures: if you are given char[][] don't write code that expects char[,]. It will be considered a failure, as we won't be able to run automated checks.
- Do not create any UI like desktop or web applications. (Some people did this)
- Do not overcomplicate things e.g. by splitting a simple solution into multiple services and utilizing DI (Some people did this).
- Please do not put your solution into 7Z or RAR archives (ZIP is ok).
