/* Selection Sort - Sort Exam Scores
Problem Statement:
A university needs to sort students’ exam scores in ascending order. Implement Selection Sort in C# to achieve this.
Hint:
Find the minimum element in the array.
Swap it with the first unsorted element.
Repeat the process for the remaining elements.
*/

using System;
class SelectionSort{
  // function to sort the array 
  static void SortExamScoreUsingSelectionSort(int[] scores){
    int n = scores.Length;
    for (int i = 0; i < n - 1; i++){
      int minIndex = i;
      // Finding the minimum element
      for (int j = i + 1; j < n; j++){
        if (scores[j] < scores[minIndex]){
          minIndex = j;
        }
      }
      if (minIndex != i){
        int temp = scores[i];
        scores[i] = scores[minIndex];
        scores[minIndex] = temp;
      }
    }
  }
  static void Main(){
    Console.Write("Enter number of students: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int[] scores = new int[n];
    Console.WriteLine("Enter exam scores:");
    for (int i = 0; i < n; i++){
      scores[i] = Convert.ToInt32(Console.ReadLine());
    }
    SortExamScoreUsingSelectionSort(scores);
    Console.WriteLine("\nSorted exam scores:");
    for (int i = 0; i < n; i++){
      Console.Write(scores[i] + " ");
    }
  }
}