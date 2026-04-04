/*Write a program FizzBuzz, take a number as user input and if it is a positive integer loop from 0 to the number and save the number, but for multiples of 3 save "Fizz" instead of the number, for multiples of 5 save "Buzz", and for multiples of both save "FizzBuzz". Finally, print the array results for each index position in the format Position 1 = 1, …, Position 3 = Fizz,...
Hint => 
Create a String Array to save the results and 
Finally, loop again to show the results of the array based on the index position
*/

using System;

public class FizzBuzz{
      public static void Main(string[] args){
            string[] fizzBuzz = new string[100];

            int number = Convert.ToInt32(Console.ReadLine());


            for(int i=1;i<=number;i++){
                  if(i%3==0 && i%5==0 && i!=1){
                        fizzBuzz[i] = "FizzBuzz";
                  }
                  else if(i%3==0){
                        fizzBuzz[i] = "Fizz";
                  }
                  else if(i%5==0){
                        fizzBuzz[i] = "Buzz";
                  }
                  else{
                        fizzBuzz[i] = i.ToString();
                  }
            }

            for(int i=1;i<=number;i++){
                  Console.WriteLine($"Position {i} = {fizzBuzz[i]}");
            }
      }
}