using System;
using System.Text;
using System.Text.RegularExpressions;

public class Program
{
      public string cleanseAndInvert(string input)
      {
            if (string.IsNullOrEmpty(input)|| input.Length < 6)
            {
                  return "";
            }

            if(!Regex.IsMatch(input, @"^[a-zA-Z]+$"))
            {
                  return "";
            }

            input = input.ToLower();

            StringBuilder filtered = new StringBuilder();

            foreach(char c in input)
            {
                  if(((int)c) % 2 != 0)
                  {
                        filtered.Append(c);
                  }
            }

            char[] arr = filtered.ToString().ToCharArray();
            Array.Reverse(arr);
            

            for(int i = 0; i < arr.Length; i++)
            {
                 if(i%2==0)
                 {
                       arr[i] = char.ToUpper(arr[i]);
                 }
            }

            return new string(arr);
      }


      public static void Main(string[] args)
      {
            Program program = new Program();
            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();
            string result = program.cleanseAndInvert(input);
             
            if (string.IsNullOrEmpty(result))
                  Console.WriteLine("Invalid Input");
            else
                  Console.WriteLine("The generated key is - " + result);
             
      }
}
