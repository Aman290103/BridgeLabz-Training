/*Binary Search Problem 1: Find the Rotation Point in a Rotated Sorted Array
Problem: You are given a rotated sorted array. Write a program that performs Binary Search to find the index of the smallest element in the array.
*/

using System;
class ReverseString{
    static void Main(){
        Console.Write("Enter a string: ");
        string str = Console.ReadLine();
         // Create StringBuilder object with str string
        StringBuilder sb = new StringBuilder(str);
        int left = 0;
        int right = sb.Length - 1;
        // Swap characters from both ends
        while (left < right){
            char temp = sb[left];
            sb[left] = sb[right];
            sb[right] = temp;
            left++;
            right--;
        }
        Console.WriteLine("Reversed string: " + sb.ToString());
    }
}