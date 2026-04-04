/*Problem 2: Date Arithmetic
Create a program that:
● Takes a date input and adds 7 days, 1 month, and 2 years to it.
● Then subtracts 3 weeks from the result.
Hint: Use DateTime.AddDays(), DateTime.AddMonths(), DateTime.AddYears(),
and DateTime.AddWeeks() methods.*/

using System;

public class DateArithematic{
      public static void Main(string[] args){
            Console.WriteLine("Enter a date (yyyy-MM-dd):");
            string input = Console.ReadLine();
            DateTime date;
            if(DateTime.TryParse(input, out date)){
                  DateTime newDate = date.AddDays(7).AddMonths(1).AddYears(2).AddDays(-21);
                  Console.WriteLine($"Original Date: {date.ToString("yyyy-MM-dd")}");
                  Console.WriteLine($"New Date after adding 7 days, 1 month, 2 years and subtracting 3 weeks: {newDate.ToString("yyyy-MM-dd")}");
            } else {
                  Console.WriteLine("Invalid date format. Please enter the date in yyyy-MM-dd format.");
            }
      }     
}