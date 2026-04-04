/*Linear Search Problem 2: Search for a Specific Word in a List of Sentences
Problem: You are given an array of sentences. Write a program that performs Linear Search to find the first sentence containing a specific word.
*/

using System;
class SearchWord{
    static void Main(){
        Console.Write("Enter number of sentences: ");
        int n = int.Parse(Console.ReadLine());
        string[] sentences = new string[n];
        Console.WriteLine("Enter the sentences:");
        for (int i = 0; i < n; i++){
            sentences[i] = Console.ReadLine();
        }
        Console.Write("\nenter the word to search");
        string word = Console.ReadLine();
        int index = -1;
        // Linear Search
        for (int i = 0; i < sentences.Length; i++){
            if (sentences[i].IndexOf(word, StringComparison.OrdinalIgnoreCase) >= 0){
                index = i;
                break;
            }
        }
        if (index != -1){
            Console.WriteLine($"\nfirst sentence containing '{word}' is at index {index}:\n{sentences[index]}");
        }else{
            Console.WriteLine($"\nno sentence contains the word'{word}'.");
        }
    }
}