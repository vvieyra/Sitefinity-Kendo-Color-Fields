Type.RegisterNamespace("ColorFields.Sitefinity.Fields.Picker");
ColorFields.Sitefinity.Fields.Picker.KendoColorPickerField = function (element)
{
    ColorFields.Sitefinity.Fields.Picker.KendoColorPickerField.initializeBase(this, [element]);
    this._element = element;
    this._labelElement = null;
    this._textBoxElement = null;
}

ColorFields.Sitefinity.Fields.Picker.KendoColorPickerField.prototype = {
    initialize: function () {
        ColorFields.Sitefinity.Fields.Picker.KendoColorPickerField.callBaseMethod(this, "initialize");
        jQuery('#' + this._textBoxElement.id).kendoColorPicker({
            buttons: false,
        });
    },
    dispose: function () {
        ColorFields.Sitefinity.Fields.Picker.KendoColorPickerField.callBaseMethod(this, "dispose");
    },
    _getTextValue: function () {
        if (this._textBoxElement) {
            return this._textBoxElement.value;
        }
        return null;
    },
    _clearTextBox: function () {
        if (this._textBoxElement != null) {
            this._textBoxElement.value = "";
        }
    },
    get_value: function (value) {
        var val = this._getTextValue();
        return val;
    },
    set_value: function (value) {
        this._clearTextBox();
        if (value !== undefined && value != null && this._textBoxElement != null) {
            this._textBoxElement.value = value;
            var colorPicker = jQuery('#' + this._textBoxElement.id).data('kendoColorPicker');
            if (colorPicker !== undefined)
                colorPicker.value(value);
        }
        this._value = value;
    },
    get_textBoxElement: function () {
        return this._textBoxElement;
    },
    set_textBoxElement: function (value) {
        this._textBoxElement = value;
    }
};
ColorFields.Sitefinity.Fields.Picker.KendoColorPickerField.registerClass("ColorFields.Sitefinity.Fields.Picker.KendoColorPickerField", Telerik.Sitefinity.Web.UI.Fields.FieldControl);