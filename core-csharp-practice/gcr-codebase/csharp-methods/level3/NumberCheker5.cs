/*    Extend or Create a NumberChecker utility class and perform the following task. Call from the main() method the different methods and display results. Make sure all are static methods
Hint => 
b.Method to find the greatest factor of a Number using the factors array
c. Method to find the sum of the factors using factors array and return the sum
d.Method to find the product of the factors using factors array and return the product
e.Method to find product of cube of the factors using the factors array. Use Math.Pow() 
f.  Method to Check if a number is a perfect number. Perfect numbers are positive integers that are equal to the sum of their proper divisors
g.Method to find the number is an abundant number. A number is called an abundant number if the sum of its proper divisors is greater than the number itself
h.Method to find the number is a deficient number. A number is called a deficient number if the sum of its proper divisors is less than the number itself
i.  Method to Check if a number is a strong number. A number is called a strong number if the sum of the factorial of its digits is equal to the number itself
*/

using System; 

public class NumberChecker5{
      public static int[] FindFactors(int number){
            int count = 0;
            for(int i=1; i<=number; i++){
                  if(number % i == 0){
                        count++;
                  }
            }

            int[] factors = new int[count];
            int index = 0;
            for(int i=1; i<=number; i++){
                  if(number % i == 0){
                        factors[index++] = i;
                  }
            }
            return factors;
      }   
      public static int FindGreatestFactor(int[] factors){
            int greatest = Int32.MinValue;
            foreach(int factor in factors){
                  if(factor > greatest){
                        greatest = factor;
                  }
            }
            return greatest;
      }

      public static int SumOfFactors(int[] factors){
            int sum = 0;
            foreach(int factor in factors){
                  sum += factor;
            }
            return sum;
      }

      public static long ProductOfFactors(int[] factors){
            long product = 1;
            foreach(int factor in factors){
                  product *= factor;
            }
            return product;
      }     


      public static double ProductOfCubeOfFactors(int[] factors){
            double productOfCubes = 1;
            foreach(int factor in factors){
                  productOfCubes *= Math.Pow(factor, 3);
            }
            return productOfCubes;
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

            Console.WriteLine($"Greatest Factor: {FindGreatestFactor(factors)}");
            Console.WriteLine($"Sum of Factors: {SumOfFactors(factors)}");
            Console.WriteLine($"Product of Factors: {ProductOfFactors(factors)}");
            Console.WriteLine($"Product of Cube of Factors: {ProductOfCubeOfFactors(factors)}");
            Console.WriteLine($"Is Perfect Number: {IsPerfectNumber(number)}");
            Console.WriteLine($"Is Abundant Number: {IsAbundantNumber(number)}");
            Console.WriteLine($"Is Deficient Number: {IsDeficientNumber(number)}");
            Console.WriteLine($"Is Strong Number: {IsStrongNumber(number)}");                                                                                                                     
            
      }
}


