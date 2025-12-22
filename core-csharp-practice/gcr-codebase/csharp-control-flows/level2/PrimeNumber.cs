/*Write a Program to check if the given number is a prime number or not
Hint => 
A number that can be divided exactly only by itself and 1 are Prime Numbers,
Prime Numbers checks are done for numbers greater than 1
Loop through all the numbers from 2 to the user input number and check if the reminder is zero. If the reminder is zero break out from the loop as the number is divisible by some other number and is not a prime number. 
Use isPrime boolean variable to store the result*/

using System;

public class PrimeNumber{
    public static void Main(string[] args){
        Console.WriteLine("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        bool isPrime = true;
        for (int i = 2; i < num; i++){
            if (num % i == 0){
                isPrime = false;
                break;
            }
        }
        if (isPrime){
            Console.WriteLine(num + " is a prime number");
        }
        else{
            Console.WriteLine(num + " is not a prime number");
        }
    }
}
