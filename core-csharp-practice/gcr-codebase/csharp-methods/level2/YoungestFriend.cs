/*Create a program to find the youngest friends among 3 Amar, Akbar and Anthony based on their ages and tallest among the friends based on their heights and display it
Hint => 
a.Take user input for age and height for the 3 friends and store it in two arrays each to store the values for age and height of the 3 friends
b.Write a Method to find the youngest of the 3 friends
c.Write a Method to find the tallest of the 3 friends
*/

using System;     

public class YoungestFriend{
      public static int FindYoungest(int[] ages){
            int youngest = ages[0];
            for(int i=1; i<ages.Length; i++){
                  if(ages[i] < youngest){
                        youngest = ages[i];
                  }
            }
            return youngest;
      }

      public static int FindTallest(int[] heights){
            int tallest = heights[0];
            for(int i=1; i<heights.Length; i++){
                  if(heights[i] > tallest){
                        tallest = heights[i];
                  }
            }
            return tallest;
      }

      public static void Main(string[] args){
            int[] ages = new int[3];
            int[] heights = new int[3];

            string[] names = {"Amar", "Akbar", "Anthony"};

            for(int i=0; i<3; i++){
                  Console.WriteLine($"Enter the age of {names[i]}:");
                  ages[i] = Convert.ToInt32(Console.ReadLine());

                  Console.WriteLine($"Enter the height of {names[i]} (in cm):");
                  heights[i] = Convert.ToInt32(Console.ReadLine());
            }

            int youngestAge = FindYoungest(ages);
            int tallestHeight = FindTallest(heights);

            Console.WriteLine($"The youngest age among the friends is: {youngestAge}");
            Console.WriteLine($"The tallest height among the friends is: {tallestHeight} cm");
      }
}