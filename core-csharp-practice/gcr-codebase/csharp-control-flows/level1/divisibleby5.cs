/*Level 1 Practice Programs
Write a program to check if a number is divisible by 5
I/P => number
O/P => Is the number ___ divisible by 5? ___*/

using System;

public class DivisibleBy5{
	public static void  Main(string[] args){
		int num;
		Console.WriteLine("Enter a number: ");
		num = Convert.ToInt32(Console.ReadLine());
		if(num%5==0)
			Console.WriteLine($"Is the number {num} divisible by 5? True");
		else
			Console.WriteLine($"Is the number {num} divisible by 5? False");
	}
}
