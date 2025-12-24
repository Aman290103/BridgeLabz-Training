/*.Create a program to divide N number of chocolates among M children. Print the number of chocolates each child will get and also the remaining chocolates
Hint => 
Get an integer value from the user for the numberOfchocolates and numberOfChildren.
Write the method to find the number of chocolates each child gets and number of remaining chocolates
*/


using System;

public class ChocolateDistribution{
      public static int[] distribution(int numberOfChocolates, int numberOfchildren){
            int[] result=new int[2];
            result[0]=numberOfChocolates / numberOfchildren;

            result[1]=numberOfChocolates % numberOfchildren;

            return result;
      }

      public static void Main(string[] args){
            Console.WriteLine("Enter the number of Chocolates:");
            int numberOfChocolates = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the number of Children:");
            int numberOfChildren = Convert.ToInt32(Console.ReadLine());

           
           int[] result=distribution(numberOfChocolates,numberOfChildren);

            Console.WriteLine($"Each child will get {result[0]} chocolates and remaining chocolates are {result[1]}");
      }
}