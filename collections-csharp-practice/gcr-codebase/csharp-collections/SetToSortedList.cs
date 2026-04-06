/*Convert a Set to a Sorted List
Convert a HashSet<int> into a sorted list in ascending order.
Example:
Input: {5, 3, 9, 1}
Output: [1, 3, 5, 9]
*/

using System;
using System.Collections.Generic;
class SetToSortedList{
    static void Main(){
        HashSet<int> set = new HashSet<int>();
        Console.Write("Enter number of elements: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter elements:");
        for (int i = 0; i < n; i++){
            set.Add(Convert.ToInt32(Console.ReadLine()));
        }
        // Convert HashSet to List
        List<int> sortedList = new List<int>(set);
        // Sort the list
        sortedList.Sort();
        Console.WriteLine("Sorted List:");
        foreach (int item in sortedList){
            Console.Write(item + " ");
        }
    }
}