Type.registerNamespace("SitefinityWebApp.WidgetDesigners.MyTestWidget");

SitefinityWebApp.WidgetDesigners.MyTestWidget.MyTestWidgetDesigner = function (element) {
    /* Initialize Message fields */
    this._message = null;
    
    /* Calls the base constructor */
    SitefinityWebApp.WidgetDesigners.MyTestWidget.MyTestWidgetDesigner.initializeBase(this, [element]);
}

SitefinityWebApp.WidgetDesigners.MyTestWidget.MyTestWidgetDesigner.prototype = {
    /* --------------------------------- set up and tear down --------------------------------- */
    initialize: function () {
        /* Here you can attach to events or do other initialization */
        SitefinityWebApp.WidgetDesigners.MyTestWidget.MyTestWidgetDesigner.callBaseMethod(this, 'initialize');
    },
    dispose: function () {
        /* this is the place to unbind/dispose the event handlers created in the initialize method */
        SitefinityWebApp.WidgetDesigners.MyTestWidget.MyTestWidgetDesigner.callBaseMethod(this, 'dispose');
    },

    /* --------------------------------- public methods ---------------------------------- */

    findElement: function (id) {
        var result = jQuery(this.get_element()).find("#" + id).get(0);
        return result;
    },

    /* Called when the designer window gets opened and here is place to "bind" your designer to the control properties */
    refreshUI: function () {
        var controlData = this._propertyEditor.get_control().Settings; /* JavaScript clone of your control - all the control properties will be properties of the controlData too */

        /* RefreshUI Message */
        jQuery(this.get_message()).val(controlData.Message);
    },

    /* Called when the "Save" button is clicked. Here you can transfer the settings from the designer to the control */
    applyChanges: function () {
        var controlData = this._propertyEditor.get_control().Settings;

        /* ApplyChanges Message */
        controlData.Message = jQuery(this.get_message()).val();
    },

    /* --------------------------------- event handlers ---------------------------------- */

    /* --------------------------------- private methods --------------------------------- */

    /* --------------------------------- properties -------------------------------------- */

    /* Message properties */
    get_message: function () { return this._message; }, 
    set_message: function (value) { this._message = value; }
}

SitefinityWebApp.WidgetDesigners.MyTestWidget.MyTestWidgetDesigner.registerClass('SitefinityWebApp.WidgetDesigners.MyTestWidget.MyTestWidgetDesigner', Telerik.Sitefinity.Web.UI.ControlDesign.ControlDesignerBase);
