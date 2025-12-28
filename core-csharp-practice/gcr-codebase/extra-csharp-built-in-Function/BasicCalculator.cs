/*Basic Calculator:
Write a program that performs basic mathematical operations (addition, subtraction,
multiplication, division) based on user input.
● Each operation should be performed in its own function, and the program should
prompt the user to choose which operation to perform.*/

using System;

public class BasicCalculator{
      public static int GetInput(string prompt){
            Console.WriteLine(prompt);
            return Convert.ToInt32(Console.ReadLine());
      }

      public static int Add(int a, int b){
            return a + b;
      }

      public static int Subtract(int a, int b){
            return a - b;
      }

      public static int Multiply(int a, int b){
            return a * b;
      }

      public static double Divide(int a, int b){
            if(b == 0){
                  Console.WriteLine("Error: Division by zero is not allowed.");
                  return double.NaN;
            }
            return (double)a / b;
      }

      public static void Main(string[] args){
            Console.WriteLine("Select operation: 1.Add 2.Subtract 3.Multiply 4.Divide");
            int choice = GetInput("Enter choice (1-4):");

            int num1 = GetInput("Enter first number:");
            int num2 = GetInput("Enter second number:");

            switch(choice){
                  case 1:
                        Console.WriteLine($"Result: {Add(num1, num2)}");
                        break;
                  case 2:
                        Console.WriteLine($"Result: {Subtract(num1, num2)}");
                        break;
                  case 3:
                        Console.WriteLine($"Result: {Multiply(num1, num2)}");
                        break;
                  case 4:
                        double result = Divide(num1, num2);
                        if(!double.IsNaN(result)){
                              Console.WriteLine($"Result: {result}");
                        }
                        break;
                  default:
                        Console.WriteLine("Invalid choice.");
                        break;
            }
      }     
}