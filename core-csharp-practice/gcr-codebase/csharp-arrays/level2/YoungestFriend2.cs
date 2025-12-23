/*Rework the program 2, especially the Hint: if index equals maxDigit, we break from the loop. Here we want to modify to increase the size of the array i,e maxDigit by 10 if the index is equal to maxDigit. This is done to consider all digits to find the largest and second-largest number 
Hint => 
In Hint f inside the loop if the index is equal to maxDigit, increase maxDigit and make digits array to store more elements. 
To do this, we need to create a new temp array of size maxDigit, copy from the current digits array the digits into the temp array, and assign the current digits array to the temp array
Now the digits array will be able to store all digits of the number in the array and then find the largest and second largest number
*/

using System;

public class YoungestFriend2{
    public static void Main(string[] args){
        Console.WriteLine("Enter the number of friends:");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] ages = new int[n];

        Console.WriteLine($"Enter the ages of {n} friends:");

        for (int i = 0; i < n; i++){
            ages[i] = Convert.ToInt32(Console.ReadLine());
        }

        int youngestAge = ages[0];
        int secondYoungestAge = int.MaxValue;

        for (int i = 1; i < n; i++){
            if (ages[i] < youngestAge){
                secondYoungestAge = youngestAge;
                youngestAge = ages[i];
            }
            else if (ages[i] < secondYoungestAge && ages[i] != youngestAge){
                secondYoungestAge = ages[i];
            }
        }

        Console.WriteLine($"The youngest age is: {youngestAge}");
        Console.WriteLine($"The second youngest age is: {secondYoungestAge}");
    }
}
