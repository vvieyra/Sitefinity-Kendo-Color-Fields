using System;
using System.Configuration;
using System.Linq;
using Telerik.Sitefinity.Configuration;
using Telerik.Sitefinity.Localization;

namespace ColorFields.Sitefinity.Configs
{
	// TODO Complete to allow lists of colors to be saved.
	[ObjectInfo(Title = "Color Palette Swatches", Description = "Stores the colors for the module palette picker to pull from")]
	public class ColorPaletteConfig : ConfigSection
	{
		[ObjectInfo(Title = "Text", Description = "This is a sample string field.")]
		[ConfigurationProperty("Text", DefaultValue = "Hello, World!")]
		public string ExampleConfigProperty
		{
			get
			{
				return (string)this["Text"];
			}
			set
			{
				this["Text"] = value;
			}
		}
	}
}