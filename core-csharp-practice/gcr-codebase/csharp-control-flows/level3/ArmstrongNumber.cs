/*Create a program to check if a number is Armstrong or not. Use the hints to show the steps clearly in the code
Hint => 
Armstrong Number is a number whose Sum of cubes of each digit results in the original number e.g. 153 = 1^3 + 5^3 + 3^3
Get an integer input and store it in the number variable define sum variable, initialize it to zero and originalNumber variable, and assign it to the input number variable
Use the while loop till the originalNumber is not equal to zero
In the while loop find the reminder number by using the modulus operator as in  number % 10. Find the cube of the number and add it to the sum variable
Again in while loop find the quotient of the number and assign it to the original number using number / 10 expression. This removes the last digit of the original number.
Finally check if the number and the sum are the same, if same its an Armstrong number else not. So display accordingly*/

using System;

public class Armstrong{
    public static void Main(string[] args){
      
        int number = int.Parse(Console.ReadLine());
        int sum = 0;
        int originalNumber = number;

        while (originalNumber != 0){
            int remainder = originalNumber % 10;
            int cube = remainder * remainder * remainder;
            sum += cube;
            originalNumber /= 10;
        }

        if (number == sum){
            Console.WriteLine("Armstrong Number");
        }
        else{
            Console.WriteLine("Not an Armstrong Number");
        }
    }
}

