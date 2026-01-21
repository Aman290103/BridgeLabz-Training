/* Reverse a List
Write a program to reverse the elements of a given list without using built-in reverse methods. Implement it for both ArrayList and LinkedList.
Example:
Input: [1, 2, 3, 4, 5]
Output: [5, 4, 3, 2, 1]
*/

using System;
using System.Collections.Generic;
class ReverseLinkedList{
    static void Main(){
        LinkedList<int> list = new LinkedList<int>();
        Console.Write("Enter number of elements: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter elements:");
        for (int i = 0; i < n; i++){
            int value = Convert.ToInt32(Console.ReadLine());
            list.AddLast(value);
        }
        LinkedList<int> reversedList = new LinkedList<int>();
        foreach (int item in list){
            reversedList.AddFirst(item);
        }
        Console.WriteLine("Reversed LinkedList:");
        foreach (int item in reversedList){
            Console.Write(item + " ");
        }
    }
}