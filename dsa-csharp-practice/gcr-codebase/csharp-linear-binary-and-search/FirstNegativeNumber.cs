/*Linear Search Problem 1: Search for the First Negative Number
Problem: You are given an integer array. Write a program that performs Linear Search to find the first negative number in the array.
*/

using System;
class FirstNegativeNumber{
    static void Main(){
        Console.Write("Enter number of elements: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        Console.WriteLine("Enter the elements:");
        for (int i = 0; i < n; i++){
            arr[i] = int.Parse(Console.ReadLine());
        }
        int index = -1;
        // Linear Search for first negative number
        for (int i = 0; i < arr.Length; i++){
            if (arr[i] < 0){
                index = i;
                break;
            }
        }
        if (index != -1){
            Console.WriteLine($"First negative number is {arr[index]} at index {index}");
        }else{
            Console.WriteLine("No negative number found in the array.");
        }
    }
}