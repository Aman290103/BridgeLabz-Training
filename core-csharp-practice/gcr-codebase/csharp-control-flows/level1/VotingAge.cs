/*Write a program to check whether a person can vote, depending on whether his/her age is greater than or equal to 18.
Hint => 
Get integer input from the user and store it in the age variable.
If the person is 18 or older, print "The person can vote." Otherwise, print "The person cannot vote." 
I/P => age
O/P => If the person's age is greater or equal to 18 then the output is 
The person's age is ___ and can vote.
Otherwise 
The person's age is ___ and cannot vote*/

using System;

public class VotingAge{
    public static void Main(string[] args){
        int age = Convert.ToInt32(Console.ReadLine());
        if(age >= 18){
            Console.WriteLine("The person's age is "+age+" and can vote.");
        }
        else{
            Console.WriteLine("The person's age is "+age+" and cannot vote.");
        }
    }
}

