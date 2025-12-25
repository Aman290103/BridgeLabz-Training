/* Write a program that generates five 4 digit random values and then finds their average value, and their minimum and maximum value. Use Math.Random(), Math.Min(), and Math.Max().
Hint => 
a.Write a method that generates array of 4 digit random numbers given the size as a parameter as shown in the method signature 
public int[] Generate4DigitRandomArray(int size)
b.Write a method to find average, min and max value of an array 
public double[] FindAverageMinMax(int[] numbers) */

using System;     

public class OperationOnRandomNumbers{
      public int[] Generate4DigitRandomArray(int size){
            Random random = new Random();
            int[] randomNumbers = new int[size];
            for(int i=0; i<size; i++){
                  randomNumbers[i] = random.Next(1000, 10000); // Generates a 4-digit random number
            }
            return randomNumbers;
      }

      public double[] FindAverageMinMax(int[] numbers){
            int sum = 0;
            int min = numbers[0];
            int max = numbers[0];

            for(int i=0; i<numbers.Length; i++){
                  sum += numbers[i];
                  if(numbers[i] < min){
                        min = numbers[i];
                  }
                  if(numbers[i] > max){
                        max = numbers[i];
                  }
            }

            double average = (double)sum / numbers.Length;
            return new double[] { average, min, max };
      }

      public static void Main(string[] args){
            OperationOnRandomNumbers op = new OperationOnRandomNumbers();
            int[] randomNumbers = op.Generate4DigitRandomArray(5);

            Console.WriteLine("Generated 4-digit random numbers:");
            for(int i=0; i<randomNumbers.Length; i++){
                  Console.WriteLine(randomNumbers[i]);
            }

            double[] results = op.FindAverageMinMax(randomNumbers);
            Console.WriteLine($"Average: {results[0]}, Min: {results[1]}, Max: {results[2]}");
      }
}
