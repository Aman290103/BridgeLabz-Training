/*10. Create a program to divide N number of chocolates among M children.
Hint:
Get an integer value from the user for numberOfChocolates and numberOfChildren.
Find the number of chocolates each child gets and the number of remaining chocolates.
Display the results.
I/P => numberOfChocolates, numberOfChildren
O/P => The number of chocolates each child gets is ___ and the number of remaining chocolates is ___*/

using System;

public class chocolateDistributions{
    public static void Main(string[] args){
      Console.Write("Enter the number of chocolates: ");
      int numberOfChocolates = int.Parse(Console.ReadLine());

      Console.Write("Enter the number of children: ");
      int numberOfChildren = int.Parse(Console.ReadLine());

      int chocolatesPerChild = numberOfChocolates / numberOfChildren;
      int remainingChocolates = numberOfChocolates % numberOfChildren;

       Console.WriteLine("The number of chocolates each child gets is " + chocolatesPerChild + " and the number of remaining chocolates is " + remainingChocolates);
     }
}

