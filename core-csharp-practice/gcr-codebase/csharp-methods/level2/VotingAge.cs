/*  Write a program to take user input for the age of all 10 students in a class and check whether the student can vote depending on his/her age is greater or equal to 18.
Hint => 
a.Create a class public class StudentVoteChecker and define a method public boolean CanStudentVote(int age) which takes in age as a parameter and returns true or false
b.Inside the method firstly validate the age for a negative number, if a negative return is false cannot vote. For valid age check for age is 18 or above return true; else return false;
c.In the main function define an array of 10 integer elements, loop through the array by take user input for the student's age, call CanStudentVote() and display
*/

using System;

public class StudentVoteChecker{
      public static bool CanStudentVote(int age){
            if(age < 0){
                  Console.WriteLine("Invalid age. Age cannot be negative.");
                  return false;
            }
            if(age >= 18){
                  return true;
            } else {
                  return false;
            }
      }

      public static void Main(string[] args){
            int[] ages = new int[10];

            for(int i = 0; i < ages.Length; i++){
                  Console.WriteLine($"Enter the age of student {i + 1}:");
                  ages[i] = Convert.ToInt32(Console.ReadLine());
            }

            for(int i = 0; i < ages.Length; i++){
                  bool canVote = CanStudentVote(ages[i]);
                  if(canVote){
                        Console.WriteLine($"Student {i + 1} with age {ages[i]} can vote.");
                  } else {
                        Console.WriteLine($"Student {i + 1} with age {ages[i]} cannot vote.");
                  }
            }
      }
}