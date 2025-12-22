/*Write a program to create a calculator using switch...case.
Hint => 
Create two double variables named first and second and a String variable named op.
Get input values for all variables.
The input for the operator can only be one of the four values: "+", "-", "*" or "/".
Run a for loop from i = 1 to i < number.
Based on the input value of the op, perform specific operations using the switch...case statement and print the result.
If op is +, perform addition between first and second; if it is -, perform subtraction and so on.
If op is neither of those 4 values, print Invalid Operator.*/

using System;

public class Program{
    public static void Main(string[] args){

        double first = Convert.ToDouble(Console.ReadLine());
        double second = Convert.ToDouble(Console.ReadLine());
        string operation = Console.ReadLine();

        switch (operation){
            case "+":
                Console.WriteLine(first + second);
                break;
            case "-":
                Console.WriteLine(first - second);
                break;
            case "*":
                Console.WriteLine(first * second);
                break;
            case "/":
                Console.WriteLine(first / second);
                break;
            default:
                Console.WriteLine("Invalid Operator");
                break;
        }
    }
}

