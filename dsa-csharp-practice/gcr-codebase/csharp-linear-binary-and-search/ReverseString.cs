/*StringBuilder Problem 1: Reverse a String Using StringBuilder
Problem: Write a program that uses StringBuilder to reverse a given string. For example, if the input is "hello", the output should be "olleh".
*/

using System;
class ReverseString{
    static void Main(){
        Console.Write("Enter a string: ");
        string str = Console.ReadLine();
         // Create StringBuilder object with str string
        StringBuilder sb = new StringBuilder(str);
        int left = 0;
        int right = sb.Length - 1;
        // Swap characters from both ends
        while (left < right){
            char temp = sb[left];
            sb[left] = sb[right];
            sb[right] = temp;
            left++;
            right--;
        }
        Console.WriteLine("Reversed string: " + sb.ToString());
    }
}