/*
Check for a Pair with Given Sum in an Array
Problem: Given an array and a target sum, find if there exists a pair of elements whose sum is equal to the target.
Hint: Store visited numbers in a hash map and check if target - current_number exists in the map.
*/

using System;

public class Program
{
    public static bool CheckForPair(int[] arr, int target)
    {
        HashSet<int> set = new HashSet<int>();

        foreach (int num in arr)
        {
            int complement = target - num;
            if (set.Contains(complement))
            {
                return true;
            }
            set.Add(num);
        }

        return false;
    }

    public static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5 };
        int target = 6;

        bool result = CheckForPair(arr, target);
        Console.WriteLine(result); // Output: True
    }
}
