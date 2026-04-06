using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Health_check_pro
{
	public class Program
	{
		public static void Main(string[] args)
		{
			HealthCheckPro app = new HealthCheckPro();
			int choice;

			do
			{
				Console.WriteLine("\nHealth Check Pro Menu");


				Console.WriteLine("1.Validate Api Annotations");


				Console.WriteLine("2.Generate Api Documentation");


				Console.WriteLine("3.Exit");
				Console.WriteLine("Enter Your Choice");


				choice = Convert.ToInt32(Console.ReadLine());

				switch (choice)
				{
					case 1:
						app.ValidateApi();
						break;

					case 2:
						app.GenerateApiDocumentation();
						break;

					case 3:
						Console.WriteLine("Existing HealthCheck Pro");
						break;

					default:
						Console.WriteLine("Invalid Choice");
						break;
				}

			} while (choice != 3);

		}
	}
}



