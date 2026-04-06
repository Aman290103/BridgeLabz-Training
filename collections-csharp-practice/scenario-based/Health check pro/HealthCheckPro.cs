using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Health_check_pro
{
	public class HealthCheckPro
	{
		Assembly assembly = Assembly.GetExecutingAssembly();

		public void ValidateApi()
		{
			Console.WriteLine("/nAPI Validation System");

			var controllers = Assembly.GetExecutingAssembly().GetTypes().Where(t => t.IsClass && t.Name.EndsWith("Controller"));
			foreach (var controller in controllers)
			{
				Console.WriteLine($"Controller Name : {controller.Name}");
				var methods = controller.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);
				foreach (var method in methods)
				{
					var publicApi = method.GetCustomAttribute<PublicApiAttribute>();
					if (publicApi != null)
					{
						Console.WriteLine($"{method.Name} -> Missing Public Api");
					}
					else
					{
						Console.WriteLine($"{method.Name} -> Ok");
					}
				}
				Console.WriteLine();
			}


		}

		public void GenerateApiDocumentation()
		{
			Console.WriteLine("/nAPI Documentation");
			var controllers = Assembly.GetExecutingAssembly().GetTypes().Where(t => t.IsClass && t.Name.EndsWith("Controllers"));
			foreach (var controller in controllers)
			{
				Console.WriteLine($"Controller : {controller.Name}");

				var methods = controller.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);
				foreach (var method in methods)
				{
					var publicApi = method.GetCustomAttribute<PublicApiAttribute>();
					var requiresAuth = method.GetCustomAttribute<RequiresAuthAttribute>();

					if (publicApi != null)
					{
						Console.WriteLine($"Method : {method.Name}");
						Console.WriteLine($"Description : {publicApi.Description}");
						Console.WriteLine($"Auth required :{requiresAuth}");
					}
				}
			}
			Console.WriteLine();
		}
	}
}




