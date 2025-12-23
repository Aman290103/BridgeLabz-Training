/*Working with Multi-Dimensional Arrays. Write a C# program to create a 2D Array and Copy the 2D Array into a single dimension array
Hint => 
Take user input for rows and columns, create a 2D array (Matrix), and take the user input 
Copy the elements of the matrix to a 1D array. For this create a 1D array of size rows*columns as in int[] array = new int[rows * columns];
Define the index variable and Loop through the 2D array. Copy every element of the 2D array into the 1D array and increment the index
Note: For looping through the 2D array, you will need Nested for loop, Outer for loop for rows, and the inner for loops to access each element
*/

using System;

public class TwoDArray{
    public static void Main(string[] args){

        Console.WriteLine("Enter the number of rows:");
        int rows = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the number of columns:");
        int columns = Convert.ToInt32(Console.ReadLine());

        int[,] matrix = new int[rows, columns];

        Console.WriteLine("Enter the elements of the matrix:");

        for (int i = 0; i < rows; i++){
            for (int j = 0; j < columns; j++){
                matrix[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        int[] array = new int[rows * columns];
        int index = 0;

        for (int i = 0; i < rows; i++){
            for (int j = 0; j < columns; j++){
                array[index] = matrix[i, j];
                index++;
            }
        }

        Console.WriteLine("The 1D array is:");
        for (int i = 0; i < array.Length; i++){
            Console.Write(array[i] + " ");
        }
    }
}
