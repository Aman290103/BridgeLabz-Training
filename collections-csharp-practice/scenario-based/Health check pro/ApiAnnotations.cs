using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Health_check_pro
{
	[AttributeUsage(AttributeTargets.Method)]
	public class PublicApiAttribute : Attribute
	{
		public string Description { get; set; }
		public PublicApiAttribute(string description)
		{
			Description = description;
		}

	}
	[AttributeUsage(AttributeTargets.Method)]
	public class RequiresAuthAttribute : Attribute { }
}
