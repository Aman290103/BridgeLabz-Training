using System;

public static class MathUtility{
	// 1. Factorial
	public static long Factorial(int n){
		if (n < 0)
			throw new ArgumentException("Factorial of a negative number is undefined.");

		long result = 1;
		for (int i = 2; i <= n; i++)
			result *= i;

		return result;
	}

	// 2. Check if number is prime
	public static bool IsPrime(int n){
		if (n <= 1) return false;
		if (n == 2) return true;
		if (n % 2 == 0) return false;

		for (int i = 3; i * i <= n; i += 2){
			if (n % i == 0)
				return false;
		}
		return true;
	}

	// 3. Greatest Common Divisor (GCD)
	public static int GCD(int a, int b){
		a = Math.Abs(a);
		b = Math.Abs(b);

		while (b != 0){
			int temp = b;
			b = a % b;
			a = temp;
		}
		return a;
	}

	// 4. Fibonacci (nth number)
	public static long Fibonacci(int n){
		if (n < 0)
			throw new ArgumentException("Fibonacci of a negative number is undefined.");

		if (n == 0) return 0;
		if (n == 1) return 1;

		long a = 0, b = 1;
		for (int i = 2; i <= n; i++){
			long c = a + b;
			a = b;
			b = c;
		}
		return b;
	}
}
