/*Snake & Ladder – Problem Statement (Multiple Players | .NET 6+)
Objective

Build a console-based Snake & Ladder game using .NET 6 or above applying the fundamentals of C# programming, including variables, data types, operators, conditions, loops, and collections. You must follow proper programming hygiene and use Git/GitHub for version control.
🎯 Requirements
1. Game Description
Create a Snake & Ladder game with the following rules:
The board has 100 cells (1 to 100).
There are a set of fixed snakes and ladders.
A player starts at position 0.
Dice generates a random number between 1 and 6.
First player to reach exactly 100 wins.
If a dice roll goes beyond 100, the player skips the turn.
2. Multi-Player Rules
The game should support minimum 2 and maximum 4 players.
Each player takes turns one after another.
When a player lands on:
A ladder → move up to higher position.
A snake → slide down to lower position.
Display each turn details:
Player name
Dice value rolled
Old position → New position
Snake/ladder message (if applied)
3. Technical Requirements
A. .NET Fundamentals
You must use the following concepts correctly:
✔ Variables, Literals, Primitive Data Types
(int, string, bool, etc.)
✔ Operator
(Arithmetic, assignment, comparison, logical)
✔ Logical Constructs
if–else
switch
ternary operator (?:) — use at least once
for, while, do-while, foreach — use at least two types of loops
✔ Jump Statements
break
continue
✔ Functions (methods)
Make the code modular using methods such as:
RollDice()
MovePlayer()
ApplySnakeOrLadder()
CheckWin()  */

using System;

public class SnakeAndLadder{
      private const int BoardGameSize=100;
      public static int RollDice(){
            Random diceRoll = new Random();
            return diceRoll.Next(1,7);
      }

      public static int MovePlayer(int oldPosition, int diceValue){
            int newPosition = oldPosition + diceValue;
            if(newPosition > BoardGameSize){
                  return oldPosition; 
            }
            return newPosition;
      }
      public static int ApplySnakeOrLadder(int newPosition){
            switch(newPosition)
            {
                  case 3:
                        Console.WriteLine("Ladder! Climb up to 22");
                        return 22;

                  case 9:
                        Console.WriteLine("Ladder! Climb up to 34");
                        return 34;

                  case 22:
                        Console.WriteLine("Ladder! Climb up to 41");
                        return 41;
                  
                  case 29:
                        Console.WriteLine("Ladder! Climb up to 77");
                        return 77;
                  
                  case 50:
                        Console.WriteLine("Ladder! Climb up to 67");
                        return 67;
                  
                  case 71:
                        Console.WriteLine("Ladder! Climb up to 91");
                        return 92;

                  case 88:
                        Console.WriteLine("Ladder! Climb up to 99");
                        return 99;

                  case 32:
                        Console.WriteLine("Snake! Slide down to 10");
                        return 10;

                  case 36:
                        Console.WriteLine("Snake! Slide down to 10");    
                        return 10;   

                  case 48:
                        Console.WriteLine("Snake! Slide down to 26");
                        return 26;

                  case 62:
                        Console.WriteLine("Snake! Slide down to 18");   
                        return 18; 

                  case 95:    
                        Console.WriteLine("Snake! Slide down to 56");
                        return 56;

                  case 97:
                        Console.WriteLine("Snake! Slide down to 78");
                        return 78;
                  
                  default:
                        return newPosition;
            }
      }

      public static bool CheckWin(int position){
            return position == BoardGameSize;
      }


      public static void Main(string[] args){
            Console.WriteLine("Snake And Ladder Game");

            Console.WriteLine("Enter the Number Of players between(2 to 4)");
            int numberOfPlayers = Convert.ToInt32(Console.ReadLine());

            if(numberOfPlayers < 2 || numberOfPlayers > 4){
                  Console.WriteLine("Please enter between 2 to 4.");
                  return;
            }

            string p1 = "player 1";
            string p2 = "player 2";
            string p3 = "player 3";
            string p4 = "player 4";


            int position1=0;
            int position2=0;
            int position3=0;
            int position4=0;

            bool gameCompleted = false;
            int currentPlayer = 1;

            while (!gameCompleted){
                  string playerName;
                  if (currentPlayer == 1){
                        playerName = p1;
                  }
                  else if (currentPlayer == 2){
                        playerName = p2;
                  }
                  else if (currentPlayer == 3){
                        playerName = p3;
                  }
                  else{
                        playerName = p4;
                  }
                  int oldPosition;

                  if (currentPlayer == 1){
                      oldPosition = position1;
                  }
                  else if (currentPlayer == 2){
                      oldPosition = position2;
                  }
                  else if (currentPlayer == 3){
                      oldPosition = position3;
                  }
                  else{
                      oldPosition = position4;
                  }


                  int dice = RollDice();
                  Console.WriteLine($"\n{playerName} rolled a {dice}");

                  int newPosition = MovePlayer(oldPosition, dice);

                  int finalPosition;
                  if (newPosition == oldPosition){
                        Console.WriteLine($"{playerName} stays at {oldPosition} (roll exceeded 100)");
                        finalPosition = oldPosition;
                  }
                  else{
                        finalPosition = ApplySnakeOrLadder(newPosition);
                        Console.WriteLine($"{playerName}: {oldPosition} → {finalPosition}");
                  }

                  if (currentPlayer == 1) position1 = finalPosition;
                  else if (currentPlayer == 2) position2 = finalPosition;
                  else if (currentPlayer == 3) position3 = finalPosition;
                  else position4 = finalPosition;

                  if (CheckWin(finalPosition)){
                        Console.WriteLine($"\n{playerName} WINS THE GAME!");
                        gameCompleted = true;
                        break;
                  }

                  currentPlayer++;
                  if (currentPlayer > numberOfPlayers)
                        currentPlayer = 1;
            }
      }
}