using System;
using System.ComponentModel;
using System.Linq;
using System.Web.Mvc;
using Telerik.Sitefinity.Mvc;
using SitefinityWebApp.Mvc.Helpers;

namespace SitefinityWebApp.Mvc.Controllers
{
    [ControllerToolboxItem(Name = "DebugMessage", Title = "Debug Message", SectionName = "DebugWidgets")]
    public class DebugMessageController : Controller
    {
        /// <summary>
        /// This is the default Action.
        /// </summary>
        public ActionResult Index()
        {
            ViewBag.DebugMessage = DebugHelper.GetMessage();
            return View("Default");
        }
    }
}