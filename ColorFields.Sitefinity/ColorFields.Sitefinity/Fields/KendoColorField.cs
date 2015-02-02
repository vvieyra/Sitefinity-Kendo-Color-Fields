using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Web.UI.WebControls;
using Telerik.Sitefinity.Services.Search;
using Telerik.Sitefinity.Utilities.TypeConverters;
using Telerik.Sitefinity.Web.UI;
using Telerik.Sitefinity.Web.UI.Fields;

namespace ColorFields.Sitefinity.Fields
{
	[FieldDefinitionElement(typeof(KendoColorFieldDefinitionElement))]
	public class KendoColorField : FieldControl
	{
		public KendoColorField() { }
		protected override WebControl TitleControl
		{
			get
			{
				return this.TitleLabel;
			}
		}

		protected override WebControl DescriptionControl
		{
			get
			{
				return this.DescriptionLabel;
			}
		}

		protected override WebControl ExampleControl
		{
			get
			{
				return this.ExampleLabel;
			}
		}
		public override string LayoutTemplatePath
		{
			get
			{
				if (string.IsNullOrEmpty(base.LayoutTemplatePath))
					return KendoColorField.layoutTemplatePath;
				return base.LayoutTemplatePath;
			}
			set
			{
				base.LayoutTemplatePath = value;
			}
		}

		protected internal virtual Label TitleLabel
		{
			get
			{
				return this.Container.GetControl<Label>("titleLabel", true);
			}
		}
		protected internal virtual Label DescriptionLabel
		{
			get
			{
				return Container.GetControl<Label>("descriptionLabel", true);
			}
		}
		protected internal virtual Label ExampleLabel
		{
			get
			{
				return this.Container.GetControl<Label>("exampleLabel", true);
			}
		}
		protected virtual TextBox TextBoxControl
		{
			get
			{
				return this.Container.GetControl<TextBox>("fieldBox", true);
			}
		}
		[TypeConverter(typeof(ObjectStringConverter))]
		public override object Value
		{
			get { return this.TextBoxControl.Text; }
			set { this.TextBoxControl.Text = value as string; }
		}
		public string Text { get; set; }

		protected override void InitializeControls(GenericContainer container)
		{
			this.TitleLabel.Text = this.Title;
			this.ExampleLabel.Text = this.Example;
			this.DescriptionLabel.Text = this.Description;

			this.TextBoxControl.Text = this.Text;
		}
		public override IEnumerable<ScriptDescriptor> GetScriptDescriptors()
		{
			List<ScriptDescriptor> descriptors = new List<ScriptDescriptor>();

			ScriptControlDescriptor descriptor = base.GetScriptDescriptors().Last() as ScriptControlDescriptor;

			if (this.TextBoxControl != null)
			{
				descriptor.AddElementProperty("textBoxElement", this.TextBoxControl.ClientID);
			}

			descriptors.Add(descriptor);

			return descriptors.ToArray();
		}

		public const string layoutTemplatePath = "~/ColorFields.Sitefinity/CzolorFields.Sitefinity.Fields.KendoColorField.ascx";		
	}
}
