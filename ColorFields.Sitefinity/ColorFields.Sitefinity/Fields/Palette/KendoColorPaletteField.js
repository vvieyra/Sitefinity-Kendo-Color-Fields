Type.RegisterNamespace("ColorFields.Sitefinity.Fields.Palette");
ColorFields.Sitefinity.Fields.Palette.KendoColorPaletteField = function (element) {
    ColorFields.Sitefinity.Fields.Palette.KendoColorPaletteField.initializeBase(this, [element]);
    this._element = element;
    this._labelElement = null;
    this._textBoxElement = null;
}

ColorFields.Sitefinity.Fields.Palette.KendoColorPaletteField.prototype = {
    initialize: function () {
        ColorFields.Sitefinity.Fields.Palette.KendoColorPaletteField.callBaseMethod(this, "initialize");
        // TODO Complete this function to include the options in the color palette config
        jQuery('#' + this._textBoxElement.id).kendoColorPalette({
            buttons: false,
        });
    },
    dispose: function () {
        ColorFields.Sitefinity.Fields.Palette.KendoColorPaletteField.callBaseMethod(this, "dispose");
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
            var colorPalette = jQuery('#' + this._textBoxElement.id).data('kendoColorPalette');
            if (colorPalette !== undefined)
                colorPalette.value(value);
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
ColorFields.Sitefinity.Fields.Palette.KendoColorPaletteField.registerClass("ColorFields.Sitefinity.Fields.Palette.KendoColorPaletteField", Telerik.Sitefinity.Web.UI.Fields.FieldControl);