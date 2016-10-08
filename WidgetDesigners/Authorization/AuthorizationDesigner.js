Type.registerNamespace("SitefinityWebApp.WidgetDesigners.Authorization");

SitefinityWebApp.WidgetDesigners.Authorization.AuthorizationDesigner = function (element) {
    /* Initialize AuthorizationUrl fields */
    this._authorizationUrl = null;
    
    /* Initialize UnauthorizationUrl fields */
    this._unauthorizationUrl = null;
    
    /* Calls the base constructor */
    SitefinityWebApp.WidgetDesigners.Authorization.AuthorizationDesigner.initializeBase(this, [element]);
}

SitefinityWebApp.WidgetDesigners.Authorization.AuthorizationDesigner.prototype = {
    /* --------------------------------- set up and tear down --------------------------------- */
    initialize: function () {
        /* Here you can attach to events or do other initialization */
        SitefinityWebApp.WidgetDesigners.Authorization.AuthorizationDesigner.callBaseMethod(this, 'initialize');
    },
    dispose: function () {
        /* this is the place to unbind/dispose the event handlers created in the initialize method */
        SitefinityWebApp.WidgetDesigners.Authorization.AuthorizationDesigner.callBaseMethod(this, 'dispose');
    },

    /* --------------------------------- public methods ---------------------------------- */

    findElement: function (id) {
        var result = jQuery(this.get_element()).find("#" + id).get(0);
        return result;
    },

    /* Called when the designer window gets opened and here is place to "bind" your designer to the control properties */
    refreshUI: function () {
        var controlData = this._propertyEditor.get_control().Settings; /* JavaScript clone of your control - all the control properties will be properties of the controlData too */

        /* RefreshUI AuthorizationUrl */
        jQuery(this.get_authorizationUrl()).val(controlData.AuthorizationUrl);

        /* RefreshUI UnauthorizationUrl */
        jQuery(this.get_unauthorizationUrl()).val(controlData.UnauthorizationUrl);
    },

    /* Called when the "Save" button is clicked. Here you can transfer the settings from the designer to the control */
    applyChanges: function () {
        var controlData = this._propertyEditor.get_control().Settings;

        /* ApplyChanges AuthorizationUrl */
        controlData.AuthorizationUrl = jQuery(this.get_authorizationUrl()).val();

        /* ApplyChanges UnauthorizationUrl */
        controlData.UnauthorizationUrl = jQuery(this.get_unauthorizationUrl()).val();
    },

    /* --------------------------------- event handlers ---------------------------------- */

    /* --------------------------------- private methods --------------------------------- */

    /* --------------------------------- properties -------------------------------------- */

    /* AuthorizationUrl properties */
    get_authorizationUrl: function () { return this._authorizationUrl; }, 
    set_authorizationUrl: function (value) { this._authorizationUrl = value; },

    /* UnauthorizationUrl properties */
    get_unauthorizationUrl: function () { return this._unauthorizationUrl; }, 
    set_unauthorizationUrl: function (value) { this._unauthorizationUrl = value; }
}

SitefinityWebApp.WidgetDesigners.Authorization.AuthorizationDesigner.registerClass('SitefinityWebApp.WidgetDesigners.Authorization.AuthorizationDesigner', Telerik.Sitefinity.Web.UI.ControlDesign.ControlDesignerBase);
