/*Find the Most Frequent Character
Problem:
Write a C# program to find the most frequent character in a string.
Example Input:
String: "success"
Expected Output:
Most Frequent Character: 's'*/

using System;

public class MostFrequentCharacter{
    public static void Main(){
        Console.WriteLine("Enter a string:");
        string str = Console.ReadLine();
        int maxCount = 0;
        char mostFrequent = ' ';
        for (int i = 0; i < str.Length; i++){
            int count = 0;
            for (int j = 0; j < str.Length; j++){
                if (str[i] == str[j]){
                    count++;
                }
            }
            if (count > maxCount){
                maxCount = count;
                mostFrequent = str[i];
            }
        }

        Console.WriteLine("Most Frequent Character: '" + mostFrequent + "'");
    }
}

