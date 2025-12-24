/*Write a program to input the Principal, Rate, and Time values and calculate Simple Interest.
Hint => 
Simple Interest = Principal * Rate * Time / 100
Take user input for principal, rate, time
Write a method to calculate the simple interest given principle, rate and time as parameters
Output “The Simple Interest is ___ for Principal ___, Rate of Interest ___ and Time */

using System;

public class SimpleInterest{
      public static double calculateSI(double principal, double rate , double time){
            double simpleInterest = (principal * rate * time) / 100;
            return simpleInterest;
      }

      public static void Main(string[] args){

            Console.WriteLine("Enter Principal amount: ");
            double principal = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Rate of Interest: ");
            double rate = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Time (in years): ");
            double time = Convert.ToDouble(Console.ReadLine());

            double simpleInterest = calculateSI(principal,rate,time);
            Console.WriteLine($"The Simple Interest is {simpleInterest} for Principal {principal}, Rate of Interest {rate} and Time {time} years"); 
      }
}
