using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BridgeLabzTraining.EmailValidator
{
    public class EmailValidator
    {
		private static readonly string regexPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{3,}$";

		private static readonly Regex regex = new Regex(regexPattern);

		[ValidationInfo("validates email using regex")]

		public static bool validateEmail(string Email)
		{
			try
			{
				if (string.IsNullOrEmpty(Email))
				{
					return false;
				}
				return regex.IsMatch(Email);
			}
			catch (Exception ex)
			{
				Console.WriteLine("An Validation error occurred: " + ex.Message);
				return false;
			}
		}

	}
}
