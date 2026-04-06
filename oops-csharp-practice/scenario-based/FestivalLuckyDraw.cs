/* Festival Lucky Draw 🎉
At Diwali mela, each visitor draws a number.
● If the number is divisible by 3 and 5, they win a gift.
● Use if, modulus, and loop for multiple visitors.
● continue if input is invalid.*/

using System;

public class FestivalLuckyDraw{
      public static void Main(string[] args){
            Console.WriteLine("Welcome to Diwali Mela Lucky Draw");

            Console.Write("Enter the number of visitors: ");
            int totalVisitors = Convert.ToInt32(Console.ReadLine());

            for(int visitors=0;visitors<=totalVisitors;visitors++){
                  Console.WriteLine("Enter the number drawn by the visitor: ");
                  int drawnNumber = Convert.ToInt32(Console.ReadLine());

                  if(drawnNumber%3==0 && drawnNumber%5==0){
                        Console.WriteLine("You won a gift!");
                  }
                  else{
                        Console.WriteLine("Sorry, Better Luck Next Time");
                  }
            }

      }
}