/*Create a program to find the factors of a number taken as user input, store the factors in an array and display the factors. Also find the sum, sum of square of factors and product of the factors and display the results
Hint => 
Take the input for a number
Write a static Method to find the factors of the number and save them in an array and return the array. 
To find factors and save to array will have two loops. The first loop to find the count and initialize the array with the count. And the second loop save the factors into the array
Write a method to find the sum of the factors using factors array
Write a method to find the product of the factors using factors array
Write a method to find the sum of square of the factors using Math.Pow() method*/

using System;     

public class Factors{
      public static int[] FindFactors(int number){
            int count=0;
            for(int i=1;i<=number;i++){
                  if(number % i == 0){
                        count++;
                  }
            }

            int[] factors=new int[count];
            int index=0;
            for(int i=1;i<=number;i++){
                  if(number % i == 0){
                        factors[index]=i;
                        index++;
                  }
            }
            return factors;
      }

      public static int SumOfFactors(int[] factors){
            int sum=0;
            for(int i=0; i<factors.Length; i++){
                  sum+=factors[i];
            }
            return sum;
      }

      public static int ProductOfFactors(int[] factors){
            int product=1;
            for(int i=0; i<factors.Length; i++){
                  product*=factors[i];
            }
            return product;
      }

      public static double SumOfSquareOfFactors(int[] factors){
            double sumOfSquares=0;
            for(int i=0; i<factors.Length; i++){
                  sumOfSquares+=Math.Pow(factors[i],2);
            }
            return sumOfSquares;
      }

      public static void Main(string[] args){
            Console.WriteLine("Enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());

            int[] factors = FindFactors(number);

            Console.WriteLine("Factors are: ");
            for(int i=0; i<factors.Length; i++){
                  Console.Write(factors[i] + " ");
            }
            Console.WriteLine();

            int sum = SumOfFactors(factors);
            Console.WriteLine($"Sum of factors: {sum}");

            int product = ProductOfFactors(factors);
            Console.WriteLine($"Product of factors: {product}");

            double sumOfSquares = SumOfSquareOfFactors(factors);
            Console.WriteLine($"Sum of square of factors: {sumOfSquares}");
      }
}
