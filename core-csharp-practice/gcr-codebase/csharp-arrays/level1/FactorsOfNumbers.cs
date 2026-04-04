/*Create a program to find the factors of a number taken as user input, store the factors in an array, and display the factors
Hint => 
Take the input for a number
Find the factors of the number and save them in an array. For this create integer variable maxFactor and initialize to 10, factors array of size maxFactor and index variable to reflect the index of the array. 
To find factors loop through the numbers from 1 to the number, find the factors, and add them to the array element by incrementing the index. If the index is equal to maxIndex, then need factors array to store more elements
To store more elements, reset the maxIndex to twice its size, use the temp array to store the elements from the factors array, and eventually assign the factors array to the temp array
Finally, Display the factors of the number*/


using System;

public class Factors{
     public static void Main(string[] args){
        Console.WriteLine("Enter a number: ");
        int number=Convert.ToInt32(Console.ReadLine());
        int maxFactor = 10;
        int index = 0;
        int[] factors = new int[maxFactor];

        for(int i = 1; i <= number; i++){
            if(number % i == 0){
                factors[index] = i;
                index++;
                if(index == maxFactor){
                    int[] temp = new int[maxFactor * 2];
                    for(int j = 0; j < maxFactor; j++){
                        temp[j] = factors[j];
                    }
                    factors = temp;
                    maxFactor *= 2;
                }
            }
        }

        Console.WriteLine($"Factors of {number} are: ");
        for(int i = 0; i < index; i++){
            Console.Write(factors[i] + " ");
        }
     }
}
