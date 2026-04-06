using System;

class Program{
	static void Main(){
		while (true){
			Console.WriteLine("\n===== Math Utility Menu =====");
			Console.WriteLine("1. Factorial");
			Console.WriteLine("2. Check Prime");
			Console.WriteLine("3. GCD of Two Numbers");
			Console.WriteLine("4. Nth Fibonacci Number");
			Console.WriteLine("5. Exit");
			Console.Write("Enter your choice: ");

			int choice;
			if (!int.TryParse(Console.ReadLine(), out choice)){
				Console.WriteLine("Invalid input. Please enter a number.");
				continue;
			}
			try{
				switch (choice){
					case 1:
						Console.Write("Enter a number: ");
						int factNum = int.Parse(Console.ReadLine());
						Console.WriteLine($"Factorial of {factNum} = {MathUtility.Factorial(factNum)}");
						break;

					case 2:
						Console.Write("Enter a number: ");
						int primeNum = int.Parse(Console.ReadLine());
						Console.WriteLine(primeNum +
							(MathUtility.IsPrime(primeNum) ? " is a prime number." : " is not a prime number."));
						break;

					case 3:
						Console.Write("Enter first number: ");
						int a = int.Parse(Console.ReadLine());
						Console.Write("Enter second number: ");
						int b = int.Parse(Console.ReadLine());
						Console.WriteLine($"GCD({a}, {b}) = {MathUtility.GCD(a, b)}");
						break;

					case 4:
						Console.Write("Enter n: ");
						int n = int.Parse(Console.ReadLine());
						Console.WriteLine($"Fibonacci({n}) = {MathUtility.Fibonacci(n)}");
						break;

					case 5:
						Console.WriteLine("Exiting program. Thank you!");
						return;

					default:
						Console.WriteLine("Invalid choice. Please select between 1 and 5.");
						break;
				}
			}
			catch (Exception ex){
				Console.WriteLine("Error: " + ex.Message);
			}
		}
	}
}
