using System;
using System.ComponentModel;
using System.Linq;
using System.Web.Mvc;
using SitefinityWebApp.Mvc.Helpers;
using Telerik.Sitefinity.Mvc;
using SitefinityWebApp.Mvc.Models;

namespace SitefinityWebApp.Mvc.Controllers
{
    [ControllerToolboxItem(Name = "Authorization", Title = "Authorization", SectionName = "MvcWidgets")]
    [Telerik.Sitefinity.Web.UI.ControlDesign.ControlDesigner(typeof(WidgetDesigners.Authorization.AuthorizationDesigner))]
    public class AuthorizationController : Controller
    {
        /// <summary>
        /// Gets or sets the AuthorizationUrl.
        /// </summary>
        [Category("String Properties")]
        public string AuthorizationUrl { get; set; }

        /// <summary>
        /// Gets or sets the UnauthorizationUrl.
        /// </summary>
        [Category("String Properties")]
        public string UnauthorizationUrl { get; set; }

        /// <summary>
        /// This is the default Action.
        /// </summary>
        public ActionResult Index()
        {
            var model = new AuthorizationModel
            {
                AuthorizationUrl = string.IsNullOrEmpty(AuthorizationUrl) ? "\'default\'" : AuthorizationUrl,
                UnauthorizationUrl = string.IsNullOrEmpty(UnauthorizationUrl) ? "sign-in" : UnauthorizationUrl
            };

            if (Request.RawUrl.Contains("Edit") || Request.RawUrl.Contains("Sitefinity"))
            {
                return View("Default", model);
            }

            if (UserContext.IsAuthenticated)
            {
                return string.IsNullOrEmpty(AuthorizationUrl)
                    ? View("Empty")
                    : (ActionResult) Redirect(AuthorizationUrl);
            }

            return Redirect(model.UnauthorizationUrl);
        }
    }
}