using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ApplicationModels;

namespace StarterApp.Infrastructure
{
	public class FeatureControllerConvention : IControllerModelConvention
	{
		public void Apply(ControllerModel controller)
		{
			var fullNamespace = controller.ControllerType.Namespace;
			var feature = fullNamespace.Substring(fullNamespace.LastIndexOf('.') + 1);
			controller.ControllerName = feature;
		}
	}
}
