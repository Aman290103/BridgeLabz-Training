/*   Create a program to find the bonus of 10 employees based on their years of service as well as the total bonus amount the 10-year-old company Zara has to pay as a bonus, along with the old and new salary.
Hint => 
a.Zara decides to give a bonus of 5% to employees whose year of service is more than 5 years or 2% if less than 5 years
b.Create a Method to determine the Salary and years of service and return the same. Use the Math.Random() method to determine the 5-digit salary for each employee and also use the random method to determine the years of service. Define 2D Array to save the salary and years of service.
c.Write a Method to calculate the new salary and bonus based on the logic defined above and return the new 2D Array of the latest salary and bonus amount 
d.Write a Method to Calculate the sum of the Old Salary, the Sum of the New Salary, and the Total Bonus Amount and display it in a Tabular Format
*/

using System;

public class BonusOfEmployee{
    
    public static void EmployeeData(int[,] data, int empCount){
        Random rnd = new Random();

        for (int i = 0; i < empCount; i++){
            data[i, 0] = rnd.Next(10000, 100000); 
            data[i, 1] = rnd.Next(1, 11);         
        }
    }

    public static void CalculateBonus(int[,] oldData, int[,] newData, int empCount){
        for (int i = 0; i < empCount; i++){
            int oldSalary = oldData[i, 0];
            int years = oldData[i, 1];

            int bonus;
            if (years > 5){
                bonus = (int)(oldSalary * 0.05);
            }
            else{
                bonus = (int)(oldSalary * 0.02);
            }

            newData[i, 0] = oldSalary;
            newData[i, 1] = bonus;
            newData[i, 2] = oldSalary + bonus;
        }
    }

    
    public static void DisplayTotal(int[,] data, int empCount){
        int totalOld = 0, totalBonus = 0, totalNew = 0;

        Console.WriteLine("Emp\tOld Salary\tBonus\tNew Salary");

        for (int i = 0; i < empCount; i++){
            Console.WriteLine($"{i + 1}\t{data[i, 0]}\t\t{data[i, 1]}\t{data[i, 2]}");

            totalOld += data[i, 0];
            totalBonus += data[i, 1];
            totalNew += data[i, 2];
        }

        Console.WriteLine($"TOTAL\t{totalOld}\t\t{totalBonus}\t{totalNew}");
    }

   
   public  static void Main(){

        int employeeCount = 10;

        int[,] employeeData = new int[employeeCount, 2]; 
        int[,] salaryData = new int[employeeCount, 3];

        EmployeeData(employeeData, employeeCount);

        CalculateBonus(employeeData, salaryData, employeeCount);
        DisplayResult(salaryData, employeeCount);
    }
}
