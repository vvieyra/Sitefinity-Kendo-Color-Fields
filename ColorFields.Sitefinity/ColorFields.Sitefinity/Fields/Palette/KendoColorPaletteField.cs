using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;

namespace ColorFields.Sitefinity.Fields.Palette
{
	public class KendoColorPaletteField : KendoColorField
	{
		public KendoColorPaletteField() { }

		// TODO Update to include the ColorPalette Config Options
		public override IEnumerable<ScriptDescriptor> GetScriptDescriptors()
		{
			return base.GetScriptDescriptors();
		}

		public override IEnumerable<ScriptReference> GetScriptReferences()
		{
			List<ScriptReference> scripts = new List<ScriptReference>(base.GetScriptReferences());

			scripts.Add(new ScriptReference(KendoColorPaletteField.ScriptReference, typeof(KendoColorPaletteField).Assembly.FullName));

			return scripts;
		}

		public const string ScriptReference = "ColorFields.Sitefinity.Fields.Palette.KendoColorPaletteField.js";
	}
}
