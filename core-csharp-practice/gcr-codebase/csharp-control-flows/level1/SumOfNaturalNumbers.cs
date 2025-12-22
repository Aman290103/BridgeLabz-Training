
/*Write a program to find the sum of n natural numbers using while loop compare the result with the formulae n*(n+1)/2 and show the result from both computations was correct. 
Hint => 
Take the user input number and check whether it's a Natural number
If it's a natural number Compute using formulae as well as compute using while loop
Compare the two results and print the result*/

using System;

public class SumOfNaturalNumbers{
    public static void Main(){
        int n;
        int i = 1;
        int sum = 0;
        Console.Write("Enter a Number : ");
        n = Convert.ToInt32(Console.ReadLine());

        // Calculate sum using while loop
        while (i <= n){
            sum = sum + i;
            i++;
        }

        // Calculate sum using formula
        int formulaSum = n * (n + 1) / 2;

        Console.Write($"Sum of Natural Numbers is : {sum}");
        Console.Write("\nSum of Natural Numbers using Formulae is : " + formulaSum);

        // Compare results
        if(sum == formulaSum) {
            Console.Write("\nBoth results are equal!");
        }
    }
}

