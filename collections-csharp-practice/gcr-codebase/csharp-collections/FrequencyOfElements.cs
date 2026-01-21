/* Find Frequency of Elements
Given a list of strings, count the frequency of each element and return the results in a Dictionary<string, int>.
Example:
Input: {"apple", "banana", "apple", "orange"}
Output: { "apple": 2, "banana": 1, "orange": 1 }
*/

using System;
using System.Collections.Generic;
class FrequencyOfElements{
    static void Main(){
        List<string> list = new List<string>();
        Dictionary<string, int> frequency = new Dictionary<string, int>();
        Console.Write("Enter number of elements: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter elements:");
        for (int i = 0; i < n; i++){
            string item = Console.ReadLine();
            list.Add(item);
        }
        foreach (string item in list){
            if (frequency.ContainsKey(item)){
                frequency[item]++;
            }else{
                frequency[item] = 1;
            }
        }
        Console.WriteLine("Element Frequencies:");
        foreach (var pair in frequency){
            Console.WriteLine($"{pair.Key} : {pair.Value}");
        }
    }
}