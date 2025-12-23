/*Rewrite the above program using multi-dimensional array to store height, weight, and BMI in 2D array for all the persons
Hint => 
Take input for a number of persons
Create a multi-dimensional array to store weight, height and BMI. Also create an to store the weight status of the persons
       double[][] personData = new double[number][3];
       String[] weightStatus = new String[number];
Take input for weight and height of the persons and for negative values, ask the user to enter positive values
Calculate BMI of all the persons and store them in the personData array and also find the weight status and put them in the weightStatus array
Display the height, weight, BMI and status of each person*/

using System;

public class Program{
    public static void Main(string[] args){
        Console.WriteLine("Enter the number of persons:");
        int number = Convert.ToInt32(Console.ReadLine());

        double[][] personData = new double[number][];
        String[] weightStatus = new String[number];

        for (int i = 0; i < number; i++){
            personData[i] = new double[3];

            Console.WriteLine("Enter weight for person " + (i + 1) + ":");
            personData[i][0] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter height for person " + (i + 1) + ":");
            personData[i][1] = Convert.ToDouble(Console.ReadLine());

            double bmi = personData[i][0] / (personData[i][1] * personData[i][1]);

            personData[i][2] = Math.Round(bmi, 2);

            if (bmi < 18.5){
                weightStatus[i] = "Underweight";
            }
            else if (bmi >= 18.5 && bmi < 25){
                weightStatus[i] = "Normal";
            }
            else if (bmi >= 25 && bmi < 30){
                weightStatus[i] = "Overweight";
            }
            else{
                weightStatus[i] = "Obese";
            }
        }

        Console.WriteLine("Height\tWeight\tBMI\tWeight Status");

        for (int i = 0; i < number; i++){
            Console.WriteLine(personData[i][1] + "\t" + personData[i][0] + "\t" + personData[i][2] + "\t" + weightStatus[i]);
        }
    }
}

