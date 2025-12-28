/*Problem 4: Date Comparison
Write a program that:
● Takes two date inputs and compares them to check if the first date is
before, after, or the same as the second date.

Hint: Use DateTime.Compare(), DateTime.CompareTo(), or direct comparison
using DateTime methods.*/

using System;

public class DateComparison{
      public static void Main(string[] args){
            Console.WriteLine("Enter the first date (yyyy-MM-dd):");
            string input1 = Console.ReadLine();
            Console.WriteLine("Enter the second date (yyyy-MM-dd):");
            string input2 = Console.ReadLine();

            DateTime date1, date2;
            if(DateTime.TryParse(input1, out date1) && DateTime.TryParse(input2, out date2)){
                  int comparison = DateTime.Compare(date1, date2);
                  if(comparison < 0){
                        Console.WriteLine($"{date1.ToString("yyyy-MM-dd")} is before {date2.ToString("yyyy-MM-dd")}");
                  } else if(comparison > 0){
                        Console.WriteLine($"{date1.ToString("yyyy-MM-dd")} is after {date2.ToString("yyyy-MM-dd")}");
                  } else {
                        Console.WriteLine($"{date1.ToString("yyyy-MM-dd")} is the same as {date2.ToString("yyyy-MM-dd")}");
                  }
            } else {
                  Console.WriteLine("Invalid date format. Please enter the dates in yyyy-MM-dd format.");
            }
      }     
}