/*Create a program to find the shortest, tallest, and mean height of players present in a football team.
Hint => 
a. The formula to calculate the mean is: mean = sum of all elements/number of elements
b. Create an int array named heights of size 11 and get 3 digits random height in cms for each player in the range 150 cms to 250 cms
c.  Write the method to Find the sum of all the elements present in the array.
e. Write the method to find the shortest height of the players on the football team 
d. Write the method to find the mean height of the players on the football team
g. Finally display the results
f.   Write the method to find the tallest height of the players on the football team
*/

using System;     

public class HieghtOfFootballTeam{
      public static int FindShortest(int[] heights){
            int shortest = heights[0];
            for(int i=1; i<heights.Length; i++){
                  if(heights[i] < shortest){
                        shortest = heights[i];
                  }
            }
            return shortest;
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

      public static double FindMean(int[] heights){
            int sum = 0;
            for(int i=0; i<heights.Length; i++){
                  sum += heights[i];
            }
            return (double)sum / heights.Length;
      }     

      public static void Main(string[] args){
            int[] heights = new int[11];
            Random random = new Random();

            for(int i=0; i<heights.Length; i++){
                  heights[i] = random.Next(150, 251); // Generates a random height between 150 and 250 cms
            }

            int shortestHeight = FindShortest(heights);
            int tallestHeight = FindTallest(heights);
            double meanHeight = FindMean(heights);

            Console.WriteLine($"Shortest Height: {shortestHeight} cms");
            Console.WriteLine($"Tallest Height: {tallestHeight} cms");
            Console.WriteLine($"Mean Height: {meanHeight} cms");
      }
}      