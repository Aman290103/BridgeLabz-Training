/*Bubble Sort - Sort Student Marks
Problem Statement:
A school maintains student marks in an array. Implement Bubble Sort in C# to sort the student marks in ascending order.
Hint:
Traverse through the array multiple times.
Compare adjacent elements and swap them if needed.
Repeat the process until no swaps are required.
*/

using System;

class BubbleSort{
  static void SortingMarksUsingBubbleSort(int[] arr){
    int n = arr.Length;
    bool swap;
    for (int i = 0; i < n - 1; i++){
      swap = false;
      for (int j = 0; j < n - 1 - i; j++){
        if (arr[j] > arr[j + 1]){
          // Swap adjacent elements
          int temp = arr[j];
          arr[j] = arr[j + 1];
          arr[j + 1] = temp;
          swap = true;
        }
      }
      // array is sorted
      if (!swap){
        break;
      }
    }
  }
  static void Main(){
    Console.Write("Enter number of students: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int[] marks = new int[n];
    Console.WriteLine("Enter student marks:");
    for (int i = 0; i < n; i++){
      marks[i] = Convert.ToInt32(Console.ReadLine());
    }
    SortingMarksUsingBubbleSort(marks);
    Console.WriteLine("\nSorted student marks:");
    for (int i = 0; i < n; i++){
      Console.Write(marks[i] + " ");
    }
    Console.WriteLine();
  }
}