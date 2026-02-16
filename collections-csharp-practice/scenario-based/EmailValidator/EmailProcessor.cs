using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.EmailValidator
{
    public class EmailProcessor
    {
		private static readonly object fileLock = new object();

		public static void processEmails(List<string> emails)
		{
			try
			{
				List<Task> tasks = new List<Task>();

				foreach (var email in emails)
				{
					tasks.Add(Task.Run(() => validateAndSave(email)));
				}

				Task.WaitAll(tasks.ToArray());

				Console.WriteLine("All emails processed.");

			}
			catch (Exception ex)
			{
				Console.WriteLine("An error occurred while processing emails: " + ex.Message);
			}

		}

		public static void validateAndSave(string email)
		{
			bool isValid = EmailValidator.validateEmail(email);
			string fileName = isValid ? "valid_emails.txt" : "invalid_emails.txt";

			lock (fileLock)
			{
				File.AppendAllText(fileName, email + Environment.NewLine);
			}

            Console.WriteLine($"{email} -> {(isValid?"Valid":"InValid")}");
		}
	}
}
