using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.EmailValidator
{
	[AttributeUsage(AttributeTargets.Method)]
	internal class ValidationInfoAttribute : Attribute
    {
		public string Description { get; }

		public ValidationInfoAttribute(string description)
		{
			Description = description;
		}
	}
}
