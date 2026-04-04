/*Sliding Window Maximum
Problem: Given an array and a window size k, find the maximum element in each sliding window of size k.
Hint: Use a deque (double-ended queue) to maintain indices of useful elements in each window.
*/

using System;

public class SlidingWindowMaximum {
    public static int[] FindMaxSlidingWindow(int[] nums, int k) {
        if (nums == null || nums.Length == 0 || k <= 0) {
            return new int[0];
        }

        int n = nums.Length;
        int[] result = new int[n - k + 1];
        int index = 0;

        // Create a deque to store indices of elements
        LinkedList<int> deque = new LinkedList<int>();

        for (int i = 0; i < n; i++) {
            // Remove indices of elements that are out of the current window
            while (deque.Count > 0 && deque.First.Value <= i - k) {
                deque.RemoveFirst();
            }

            // Remove indices of elements that are smaller than the current element
            while (deque.Count > 0 && nums[deque.Last.Value] < nums[i]) {
                deque.RemoveLast();
            }

            // Add the current index to the deque
            deque.AddLast(i);

            // If the window has reached its size, add the maximum element to the result
            if (i >= k - 1) {
                result[index++] = nums[deque.First.Value];
            }
        }

        return result;
    }

    public static void Main(string[] args) {
        int[] nums = { 1, 2, 3, 2, 4, 2, 1 };
        int k = 3;
        int[] result = FindMaxSlidingWindow(nums, k);
        Console.WriteLine("Maximum elements in each sliding window:");
        foreach (int num in result) {
            Console.Write(num + " ");
        }
    }
}
