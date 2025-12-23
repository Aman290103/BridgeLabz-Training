/*An organization took up an exercise to find the Body Mass Index (BMI) of all the persons in the team. For this create a program to find the BMI and display the height, weight, BMI and status of each individual
Hint => 
Take input for a number of persons
Create arrays to store the weight, height, BMI, and weight status of the persons
Take input for the weight and height of the persons
Calculate the BMI of all the persons and store them in an array and also find the weight status of the persons
Display the height, weight, BMI, and weight status of each person
Use the table to determine the weight status of the person
*/

using System;

public class Program{
    public static void Main(string[] args){

        Console.WriteLine("Enter the number of persons: ");
        int numberOfPersons = Convert.ToInt32(Console.ReadLine());

        double[] weight = new double[numberOfPersons];
        double[] height = new double[numberOfPersons];
        double[] bmi = new double[numberOfPersons];
        string[] weightStatus = new string[numberOfPersons];

        for (int i = 0; i < numberOfPersons; i++){

            Console.WriteLine("Enter the weight of person " + (i + 1) + " in kg: ");
            weight[i] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the height of person " + (i + 1) + " in m: ");
            height[i] = Convert.ToDouble(Console.ReadLine());

            bmi[i] = weight[i] / (height[i] * height[i]);

            if (bmi[i] < 18.5){
                weightStatus[i] = "Underweight";
            }
            else if (bmi[i] >= 18.5 && bmi[i] < 25){
                weightStatus[i] = "Normal";
            }
            else if (bmi[i] >= 25 && bmi[i] < 30){
                weightStatus[i] = "Overweight";
            }
            else{
                weightStatus[i] = "Obese";
            }
        }

        Console.WriteLine("Height\tWeight\tBMI\tWeight Status");
        for (int i = 0; i < numberOfPersons; i++){
            Console.WriteLine(height[i] + "\t" + weight[i] + "\t" + bmi[i].ToString("0.00") + "\t" + weightStatus[i]);
        }
      }
}
