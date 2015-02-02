using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Web.UI.WebControls;
using Telerik.Sitefinity.Utilities.TypeConverters;
using Telerik.Sitefinity.Web.UI;
using Telerik.Sitefinity.Web.UI.Fields;
using Telerik.Sitefinity.Web.UI.Fields.Contracts;

namespace ColorFields.Sitefinity.Fields.Picker
{
	public class KendoColorPickerField : KendoColorField
	{
		public KendoColorPickerField() { }

		public override IEnumerable<ScriptReference> GetScriptReferences()
		{
			List<ScriptReference> scripts = new List<ScriptReference>(base.GetScriptReferences());

			scripts.Add(new ScriptReference(KendoColorPickerField.ScriptReference, typeof(KendoColorPickerField).Assembly.FullName));

			return scripts;
		}
		
		public const string ScriptReference = "ColorFields.Sitefinity.Fields.Picker.KendoColorPickerField.js";
	}
}
