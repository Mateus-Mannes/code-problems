/*
Problem Description:
    Smallest Difference: Given two arrays of integers, compute the pair of values
    with the smallest (non-negative) difference. Return the difference.

    Example:
    Input: ([1, 3, 15, 11, 2], [23, 127, 235, 19, 8])
    Output: the pair (11, 8).
*/

public class SmallestDifference
{
    public static void Run()
    {
        int[] array1 = new int[] {1, 3, 15, 11, 2};
        int[] array2 = new int[] {23, 127, 235, 19, 8};
        var pair = FindSmallestDifference(array1, array2);
        Console.WriteLine($"The pair ({pair.Item1}, {pair.Item2})");
    }

    public static Tuple<int, int> FindSmallestDifference(int[] array1, int[] array2)
    {
        int index1 = 0;
        int index2 = 0;
        var currentPair = new Tuple<int, int>(0, int.MaxValue);

        Array.Sort(array1);
        Array.Sort(array2);

        while(index1 < array1.Length && index2 < array2.Length) 
        {
            int differece = Math.Abs(array1[index1] - array2[index2]);
            int currentSmallestDifference = Math.Abs(currentPair.Item1 - currentPair.Item2);
            if(differece < currentSmallestDifference)
                currentPair = new Tuple<int, int>(array1[index1], array2[index2]);
            
            else if(array1[index1] < array2[index2]) index1++;
            else index2++;
        }
        
        return currentPair;
    }
}
