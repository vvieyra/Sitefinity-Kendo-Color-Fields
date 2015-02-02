using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.Sitefinity.Configuration;
using Telerik.Sitefinity.Web.UI.Fields.Contracts;
using Telerik.Sitefinity.Web.UI.Fields.Definitions;

namespace ColorFields.Sitefinity.Fields
{
	public class KendoColorFieldDefinition : FieldControlDefinition, IFieldControlDefinition
	{
		public KendoColorFieldDefinition() : base() { }
		public KendoColorFieldDefinition(ConfigElement configDefinition) : base() { }
	}
}
