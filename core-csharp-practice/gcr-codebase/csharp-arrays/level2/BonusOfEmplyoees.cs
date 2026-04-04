/*Create a program to find the bonus of 10 employees based on their years of service and the total bonus amount the company Zara has to pay, along with the old and new salary.
Hint => 
Zara decides to give a bonus of 5% to employees whose year of service is more than 5 years or 2% if less than 5 years
Define a double array to save salary and years of service for each of the 10 employees
Also define a double array to save the new salary and the bonus amount as well as variables to save the total bonus, total old salary, and new salary
Define a loop to take input from the user. If salary or year of service is an invalid number then ask the user to enter again. Note in this case you will have to decrement the index counter
Define another loop to calculate the bonus of 10 employees based on their years of service. Save the bonus in the array, compute the new salary, and save in the array. Also, the total bonus and total old and new salary can be calculated in the loop
Print the total bonus payout as well as the total old and new salary of all the employees
*/

using System;

public class Bonus{
      public static void Main(string[] args){
            double[] salary = new double[10];
            double[] yearsOfService = new double[10];

            double[] bonus = new double[10];
            double[] newSalary = new double[10];
            double totalBonus = 0;
            double totalOldSalary = 0;
            double totalNewSalary = 0;

            for(int i=0;i<10;i++){
                  Console.WriteLine($"Enter salary for employee {i+1}:");
                  salary[i]=Convert.ToDouble(Console.ReadLine());
                  
                  Console.WriteLine($"Enter years of service for employee {i+1}:");
                  yearsOfService[i]=Convert.ToDouble(Console.ReadLine());

                  if(salary[i]<=0 || yearsOfService[i]<=0){
                        Console.WriteLine("Invalid Input");
                        i--;
                        continue;
                  }
            }

            for(int i=0;i<10;i++){
                  if(yearsOfService[i]>5){
                        bonus[i] = 0.05 * salary[i];
                  }
                  else{
                        bonus[i] = 0.02 * salary[i];
                  }
                  
                  newSalary[i] = salary[i] + bonus[i];
                  totalBonus += bonus[i];
                  totalOldSalary += salary[i];
                  totalNewSalary += newSalary[i];
            }

            Console.WriteLine(totalBonus);
            Console.WriteLine(totalOldSalary);
            Console.WriteLine(totalNewSalary);

      }
}