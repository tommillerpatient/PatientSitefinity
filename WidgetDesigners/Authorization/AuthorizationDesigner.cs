using System;
using System.Linq;
using System.Web.UI;
using Telerik.Sitefinity.Web.UI;
using Telerik.Sitefinity.Web.UI.ControlDesign;
using System.Collections.Generic;

namespace SitefinityWebApp.WidgetDesigners.Authorization
{
    /// <summary>
    /// Represents a designer for the <typeparamref name="SitefinityWebApp.Mvc.Controllers.AuthorizationController"/> widget
    /// </summary>
    public class AuthorizationDesigner : ControlDesignerBase
    {
        #region Properties
        /// <summary>
        /// Obsolete. Use LayoutTemplatePath instead.
        /// </summary>
        protected override string LayoutTemplateName
        {
            get
            {
                return string.Empty;
            }
        }

        /// <summary>
        /// Gets the layout template's relative or virtual path.
        /// </summary>
        public override string LayoutTemplatePath
        {
            get
            {
                if (string.IsNullOrEmpty(base.LayoutTemplatePath))
                    return AuthorizationDesigner.layoutTemplatePath;
                return base.LayoutTemplatePath;
            }
            set
            {
                base.LayoutTemplatePath = value;
            }
        }

        protected override HtmlTextWriterTag TagKey
        {
            get
            {
                return HtmlTextWriterTag.Div;
            }
        }
        #endregion

        #region Control references
        /// <summary>
        /// Gets the control that is bound to the AuthorizationUrl property
        /// </summary>
        protected virtual Control AuthorizationUrl
        {
            get
            {
                return this.Container.GetControl<Control>("AuthorizationUrl", true);
            }
        }

        /// <summary>
        /// Gets the control that is bound to the UnauthorizationUrl property
        /// </summary>
        protected virtual Control UnauthorizationUrl
        {
            get
            {
                return this.Container.GetControl<Control>("UnauthorizationUrl", true);
            }
        }

        #endregion

        #region Methods
        protected override void InitializeControls(Telerik.Sitefinity.Web.UI.GenericContainer container)
        {
            // Place your initialization logic here
        }
        #endregion

        #region IScriptControl implementation
        /// <summary>
        /// Gets a collection of script descriptors that represent ECMAScript (JavaScript) client components.
        /// </summary>
        public override System.Collections.Generic.IEnumerable<System.Web.UI.ScriptDescriptor> GetScriptDescriptors()
        {
            var scriptDescriptors = new List<ScriptDescriptor>(base.GetScriptDescriptors());
            var descriptor = (ScriptControlDescriptor)scriptDescriptors.Last();

            descriptor.AddElementProperty("authorizationUrl", this.AuthorizationUrl.ClientID);
            descriptor.AddElementProperty("unauthorizationUrl", this.UnauthorizationUrl.ClientID);

            return scriptDescriptors;
        }

        /// <summary>
        /// Gets a collection of ScriptReference objects that define script resources that the control requires.
        /// </summary>
        public override System.Collections.Generic.IEnumerable<System.Web.UI.ScriptReference> GetScriptReferences()
        {
            var scripts = new List<ScriptReference>(base.GetScriptReferences());
            scripts.Add(new ScriptReference(AuthorizationDesigner.scriptReference));
            return scripts;
        }
        #endregion

        #region Private members & constants
        public static readonly string layoutTemplatePath = "~/WidgetDesigners/Authorization/AuthorizationDesigner.ascx";
        public const string scriptReference = "~/WidgetDesigners/Authorization/AuthorizationDesigner.js";
        #endregion
    }
}
 
