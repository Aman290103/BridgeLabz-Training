using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.EmailValidator
{
    public class Program
    {
        public static void Main(string[] args) 
        {
            try
            {
                Console.WriteLine("-------EduConnect Email Validator------");
                Console.WriteLine("Enter number of emails to validate:");

                int n = Convert.ToInt32(Console.ReadLine());

                List<string> emails = new List<string>();

                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine($"Enter email{i + 1}: ");
                    emails.Add(Console.ReadLine());

                }
                EmailProcessor.processEmails(emails);

            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid nnumber entered");
            }
            catch (Exception ex) 
            {
                Console.WriteLine("Unexpected Error: " + ex.Message);
            }
        }
    }
}
