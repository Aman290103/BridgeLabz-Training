/*. Symmetric Difference
Find the symmetric difference (elements present in either set but not both).
Example:
Input: {1, 2, 3}, {3, 4, 5}
Output: {1, 2, 4, 5}
*/

using System;
using System.Collections.Generic;
class SymettricDifference{
    static void Main(){
        HashSet<int> set1 = new HashSet<int>();
        HashSet<int> set2 = new HashSet<int>();
        Console.Write("Enter number of elements in Set 1: ");
        int n1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter elements of Set 1:");
        for (int i = 0; i < n1; i++){
            set1.Add(Convert.ToInt32(Console.ReadLine()));
        }
        Console.Write("Enter number of elements in Set 2: ");
        int n2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter elements of Set 2:");
        for (int i = 0; i < n2; i++){
            set2.Add(Convert.ToInt32(Console.ReadLine()));
        }
        HashSet<int> symmetricDifference = new HashSet<int>(set1);
        // Remove common elements
        symmetricDifference.SymmetricExceptWith(set2);
        Console.WriteLine("Symmetric Difference:");
        foreach (int item in symmetricDifference){
            Console.Write(item + " ");
        }
    }
}