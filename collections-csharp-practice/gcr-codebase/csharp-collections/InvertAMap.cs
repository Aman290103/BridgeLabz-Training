/*Invert a Map
Invert a Dictionary<K, V> to produce a Dictionary<V, List<K>>.
Example:
Input: { A=1, B=2, C=1 }
Output: { 1=[A, C], 2=[B] }
*/

using System;
using System.Collections.Generic;
class InvertAMap{
    static void Main(){
        Dictionary<string, int> originalMap = new Dictionary<string, int>();
        Dictionary<int, List<string>> invertedMap = new Dictionary<int, List<string>>();
        Console.Write("Enter number of entries: ");
        int n = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < n; i++){
            Console.Write("Enter key: ");
            string key = Console.ReadLine();
            Console.Write("Enter value: ");
            int value = Convert.ToInt32(Console.ReadLine());
            originalMap[key] = value;
        }
        // Invert the map
        foreach (var pair in originalMap){
            if (!invertedMap.ContainsKey(pair.Value)){
                invertedMap[pair.Value] = new List<string>();
            }
            invertedMap[pair.Value].Add(pair.Key);
        }
        Console.WriteLine("\nInverted Map:");
        foreach (var pair in invertedMap){
            Console.Write(pair.Key + " = [ ");
            foreach (string key in pair.Value){
                Console.Write(key + " ");
            }
            Console.WriteLine("]");
        }
    }
}