using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.Sitefinity.Configuration;
using Telerik.Sitefinity.Web.UI;
using Telerik.Sitefinity.Web.UI.Fields.Config;
using Telerik.Sitefinity.Web.UI.Fields.Contracts;

namespace ColorFields.Sitefinity.Fields
{
	public class KendoColorFieldDefinitionElement : FieldControlDefinitionElement, IFieldControlDefinition
	{
		public KendoColorFieldDefinitionElement(ConfigElement parent) : base(parent) { }
		public override DefinitionBase GetDefinition()
		{
			return new KendoColorFieldDefinition(this);
		}
		public override Type DefaultFieldType
		{
			get
			{
				return typeof(KendoColorField);
			}
		}
	}
}
