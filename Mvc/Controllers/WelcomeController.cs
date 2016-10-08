using System;
using System.ComponentModel;
using System.Linq;
using System.Web.Mvc;
using SitefinityWebApp.Mvc.Helpers;
using Telerik.Sitefinity.Mvc;

namespace SitefinityWebApp.Mvc.Controllers
{
    [ControllerToolboxItem(Name = "Welcome", Title = "Welcome", SectionName = "PageWidgets")]
    public class WelcomeController : Controller
    {
        /// <summary>
        /// This is the default Action.
        /// </summary>
        public ActionResult Index()
        {
            return View("Default");
        }
    }
}