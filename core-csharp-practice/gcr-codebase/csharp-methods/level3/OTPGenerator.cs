/*  Write a program to generate a six-digit OTP number using Math.Random() method. Validate the numbers are unique by generating the OTP number 10 times and ensuring all the 10 OTPs are not the same
Hint => 
a.Write a method to Generate a 6-digit OTP number using Math.Random() 
b.Create an array to save the OTP numbers generated 10 times
c.Write a method to ensure that the OTP numbers generated are unique. If unique return true else return false
*/

using System;

public class OTPGenerator{
      public static int GenerateOTP(){
            Random random = new Random();
            int otp = random.Next(100000, 1000000); // Generates a 6-digit OTP
            return otp;
      }

      public static bool AreOTPUnique(int[] otps){
            for(int i=0; i<otps.Length; i++){
                  for(int j=i+1; j<otps.Length; j++){
                        if(otps[i] == otps[j]){
                              return false; // Found a duplicate OTP
                        }
                  }
            }
            return true; // All OTPs are unique
      }

      public static void Main(string[] args){
            int[] otps = new int[10];

            for(int i=0; i<10; i++){
                  otps[i] = GenerateOTP();
                  Console.WriteLine($"Generated OTP {i+1}: {otps[i]}");
            }

            bool unique = AreOTPUnique(otps);
            if(unique){
                  Console.WriteLine("All generated OTPs are unique.");
            } else {
                  Console.WriteLine("There are duplicate OTPs generated.");
            }
      }
} 