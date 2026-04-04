/*Problem:
You are given a list of integers. Write a program that uses Linear Search to find the first missing positive integer in the list and Binary Search to find the index of a given target number.
Approach:
Linear Search for the first missing positive integer:
Iterate through the list and mark each number in the list as visited (you can use negative marking or a separate array).
Traverse the array again to find the first positive integer that is not marked.
Binary Search for the target index:
After sorting the array, perform binary search to find the index of the given target number.
Return the index if found, otherwise return -1.
*/

using System;
class FirstMissingPositiveInteger{
    static void Main(){
        Console.Write("Enter number of elements: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        Console.WriteLine("Enter elements:");
        for (int i = 0; i < n; i++){
            arr[i] = int.Parse(Console.ReadLine());
        }
        //Linear Search for First Missing Positive 
        int firstMissing = FindFirstMissingPositive(arr);
        Console.WriteLine($"\nFirst Missing Positive Number: {firstMissing}");
        // Binary Search for Target Index 
        Console.Write("\nEnter target value to search: ");
        int target = int.Parse(Console.ReadLine());
        Array.Sort(arr); 
        int index = BinarySearch(arr, target);
        if (index != -1){
            Console.WriteLine($"target {target} found at index {index} .");
        }else{
            Console.WriteLine("target not foun");
        }
    }
    static int FindFirstMissingPositive(int[] nums){
        int n = nums.Length;
        bool[] visited = new bool[n + 1];
        // Mark visited positive numbers
        for (int i = 0; i < n; i++){
            if (nums[i] > 0 && nums[i] <= n){
                visited[nums[i]] = true;
            }
        }
        // Find first missing positive
        for (int i = 1; i <= n; i++){
            if (!visited[i])
                return i;
        }
        return n + 1;
    }
    static int BinarySearch(int[] arr, int target){
        int left = 0;
        int right = arr.Length - 1;
        while (left <= right){
            int mid = (left + right) / 2;
            if (arr[mid] == target){
                return mid;
            }
            else if (arr[mid] < target){
                left = mid + 1;
            }
            else{
                right = mid - 1;
            }
        }
        return -1;
    }
}