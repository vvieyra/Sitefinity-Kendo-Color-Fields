using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.Sitefinity.Abstractions;
using Telerik.Sitefinity.Abstractions.VirtualPath.Configuration;
using Telerik.Sitefinity.Configuration;
using Telerik.Sitefinity.Data;

namespace ColorFields.Sitefinity
{
	public class Initializer
	{
		public static void PreApplicationStart() 
		{
			Bootstrapper.Initialized += Initializer.Bootstrapper_Initialized;
		}
		public static void Bootstrapper_Initialized(object sender, ExecutedEventArgs e) 
		{
			if (e.CommandName == "RegisterRoutes") 
			{
				//Register Virtual Path
				var virtualPathConfig = Config.Get<VirtualPathSettingsConfig>();
				var jobsModuleVirtualPathConfig = new VirtualPathElement(virtualPathConfig.VirtualPaths)
				{
					VirtualPath = "~/ColorFields.Sitefinity/*",
					ResolverName = "EmbeddedResourceResolver",
					ResourceLocation = "ColorFields.Sitefinity"
				};
				virtualPathConfig.VirtualPaths.Add(jobsModuleVirtualPathConfig);

				//Register Custom Config
				// TODO Complete
			}
		}
	}
}
