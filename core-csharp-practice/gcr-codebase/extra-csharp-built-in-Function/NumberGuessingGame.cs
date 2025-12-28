/*1. Number Guessing Game:
Write a program where the user thinks of a number between 1 and 100, and the computer
tries to guess the number by generating random guesses.
● The user provides feedback by indicating whether the guess is high, low, or correct.
● The program should be modular, with different functions for generating guesses,
receiving user feedback, and determining the next guess.*/

using System;

public class NumberGuessingGame{
      public static int GenerateGuess(int min, int max){
            Random rand = new Random();
            return rand.Next(min, max + 1);
      }

      public static string GetUserFeedback(int guess){
            Console.WriteLine($"Is your number {guess}? (h/l/c): ");
            return Console.ReadLine().ToLower();
      }

      public static void Main(string[] args){
            int min = 1;
            int max = 100;
            string feedback = "";

            Console.WriteLine("Think of a number between 1 and 100. I will try to guess it!");

            while(feedback != "c"){
                  int guess = GenerateGuess(min, max);
                  feedback = GetUserFeedback(guess);

                  if(feedback == "h"){
                        max = guess - 1;
                  } else if(feedback == "l"){
                        min = guess + 1;
                  } else if(feedback != "c"){
                        Console.WriteLine("Invalid input. Please enter 'h' for high, 'l' for low, or 'c' for correct.");
                  }
            }

            Console.WriteLine("I guessed your number!");
      }     
}