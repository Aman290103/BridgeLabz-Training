/*Create a program to print odd and even numbers between 1 to the number entered by the user.
Hint => 
Get an integer input from the user, assign to a variable number and check for Natural Number
Using a for loop, iterate from 1 to the number
// In each iteration of the loop, print the number is odd or even number*/

using System;

class Program {
    public static void Main (string[] args) {
      Console.WriteLine("Enter a number:");
        int number = Convert.ToInt32(Console.ReadLine());
        for(int i=1;i<=number;i++){
            if(i%2==0){
                Console.WriteLine(i+" is even");
            }
            else{
                Console.WriteLine(i+" is odd");
            }
        }
    }
}

