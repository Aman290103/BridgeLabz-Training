/*Problem 1: Time Zones and DateTimeOffset
Write a program that displays the current time in different time zones:
● GMT (Greenwich Mean Time)
● IST (Indian Standard Time)
● PST (Pacific Standard Time)
Hint: Use DateTimeOffset and TimeZoneInfo to work with different time zones.*/

using System;     

public class TimeZonesAndDateTimeOffset{
      public static void Main(string[] args){
            DateTimeOffset utcNow = DateTimeOffset.UtcNow;

            TimeZoneInfo gmtZone = TimeZoneInfo.FindSystemTimeZoneById("GMT Standard Time");
            TimeZoneInfo istZone = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
            TimeZoneInfo pstZone = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");

            DateTimeOffset gmtTime = TimeZoneInfo.ConvertTime(utcNow, gmtZone);
            DateTimeOffset istTime = TimeZoneInfo.ConvertTime(utcNow, istZone);
            DateTimeOffset pstTime = TimeZoneInfo.ConvertTime(utcNow, pstZone);

            Console.WriteLine($"Current GMT Time: {gmtTime}");
            Console.WriteLine($"Current IST Time: {istTime}");
            Console.WriteLine($"Current PST Time: {pstTime}");
      }     
}