/*
Problem Description:
    Smallest Difference: Given two arrays of integers, compute the pair of values
    with the smallest (non-negative) difference. Return the difference.

    Example:
    Input: ([1, 3, 15, 11, 2], [23, 127, 235, 19, 8])
    Output: the pair (11, 8).
*/

using System;

public class Program
{
    public static void Main()
    {
        // Initialize your input arrays here
        int[] array1 = new int[] {1, 3, 15, 11, 2};
        int[] array2 = new int[] {23, 127, 235, 19, 8};
        
        // Call your method here
    }

    // Define your method here. 
    // It should take two int arrays as parameters and return a Tuple<int, int>.
    public static Tuple<int, int> FindSmallestDifference(int[] array1, int[] array2)
    {
        // Your code here

        // get a index for array 1
        int index1 = 0;
        // get a index for array 2
        int index2 = 0;
        // get a var for the difference
        int smallestDifference = Int32.MaxValue;
        // start a while loop until both indexes get to the end
        while(index1 < array1.Lenght || index2 < array2.Lenght) {
            // compute the smallest differece
            // increment the index of the smallest number
        }
        

        // Remember to return a tuple of two integers
        return Tuple.Create(0, 0);
    }
}
