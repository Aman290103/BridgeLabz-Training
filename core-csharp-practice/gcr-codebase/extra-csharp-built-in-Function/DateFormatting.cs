/*Problem 3: Date Formatting
Write a program that:
● Displays the current date in three different formats:
o dd/MM/yyyy
o yyyy-MM-dd
o EEE, MMM dd, yyyy

Hint: Use DateTime.ToString() with custom date format strings.*/

using System;

public class DateFormatting{
      public static void Main(string[] args){
            DateTime currentDate = DateTime.Now;

            string format1 = currentDate.ToString("dd/MM/yyyy");
            string format2 = currentDate.ToString("yyyy-MM-dd");
            string format3 = currentDate.ToString("ddd, MMM dd, yyyy");

            Console.WriteLine($"Current Date in dd/MM/yyyy format: {format1}");
            Console.WriteLine($"Current Date in yyyy-MM-dd format: {format2}");
            Console.WriteLine($"Current Date in EEE, MMM dd, yyyy format: {format3}");
      }     
}