/*Create a program to find the youngest friends among 3 Amar, Akbar, and Anthony based on their ages and the tallest among the friends based on their heights
Hint => 
Take user input for age and height for the 3 friends and store it in two arrays each to store the values for age and height of the 3 friends
Loop through the array and find the youngest of the 3 friends and the tallest of the 3 friends
Finally display the youngest and tallest of the 3 friends*/

using System;

public class YoungestFriend{
      public static void Main(string[] args){
            int[] age = new int[3];
            int[] height = new int[3];
            int youngest = 0;
            int tallest = 0;

            for(int i = 0; i < 3; i++){
                  Console.WriteLine("Enter the age of the friend: ");
                  age[i] = Convert.ToInt32(Console.ReadLine());
                  
                  Console.WriteLine("Enter the height of the friend: ");
                  height[i] = Convert.ToInt32(Console.ReadLine());
            }

            youngest = age[0];
            tallest = height[0];

            for(int i = 0; i < 3; i++){
                  if(age[i] < youngest){
                        youngest = age[i];
                  }
                  if(height[i] > tallest){
                        tallest = height[i];
                  }
            }

            Console.WriteLine("The youngest friend is: " + youngest);
            Console.WriteLine("The tallest friend is: " + tallest);
      }
}
