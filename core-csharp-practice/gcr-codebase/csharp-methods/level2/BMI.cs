/*  An organization took up the exercise to find the Body Mass Index (BMI) of all the persons in the team of 10 members. For this create a program to find the BMI and display the height, weight, BMI and status of each individual
Hint => 
a.Take user input in double for the weight (in kg) of the person and height (in cm) for the person and store it in the corresponding 2D array of 10 rows and 3 columns. The First Column storing the weight, the second column storing the height in cm and the third column is the BMI
b.Create a Method to find the BMI of every person and populate the array. Use the formula BMI = weight / (height * height). Note unit is kg/m^2. For this convert cm to meter
c.Create a Method to determine the BMI status using the logic shown in the figure below. and return the array of all the persons BMI status
*/

using System;

public class BMI{
      public static double CalculateBMI(double weight, double heightCm){
            double heightM = heightCm / 100; // Convert cm to meters
            double bmi = weight / (heightM * heightM);
            return bmi;
      }

      public static string DetermineBMIStatus(double bmi){
            if(bmi < 18.5){
                  return "Underweight";
            } else if(bmi >= 18.5 && bmi < 24.9){
                  return "Normal weight";
            } else if(bmi >= 25 && bmi < 29.9){
                  return "Overweight";
            } else {
                  return "Obesity";
            }
      }

      public static void Main(string[] args){
            double[,] data = new double[10, 3]; // 10 rows, 3 columns (weight, height, BMI)

            for(int i = 0; i < 10; i++){
                  Console.WriteLine($"Enter weight (in kg) of person {i + 1}:");
                  data[i, 0] = Convert.ToDouble(Console.ReadLine());

                  Console.WriteLine($"Enter height (in cm) of person {i + 1}:");
                  data[i, 1] = Convert.ToDouble(Console.ReadLine());

                  data[i, 2] = CalculateBMI(data[i, 0], data[i, 1]);
            }

            Console.WriteLine("Height(cm)\tWeight(kg)\tBMI\t\tStatus");
            for(int i = 0; i < 10; i++){
                  string status = DetermineBMIStatus(data[i, 2]);
                  Console.WriteLine($"{data[i, 1]}\t\t{data[i, 0]}\t\t{data[i, 2]:F2}\t\t{status}");
            }
      }
}