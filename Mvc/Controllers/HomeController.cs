using System;
using System.ComponentModel;
using System.Linq;
using System.Web.Mvc;
using Telerik.Sitefinity.Mvc;
using SitefinityWebApp.Mvc.Models;
using SitefinityWebApp.Mvc.Helpers;

namespace SitefinityWebApp.Mvc.Controllers
{
    [ControllerToolboxItem(Name = "Home", Title = "Home", SectionName = "MvcWidgets")]
    public class HomeController : Controller
    {
        /// <summary>
        /// This is the default Action.
        /// </summary>
        public ActionResult Index()
        {
            //DebugHelper.SetMessage(Request.Cookies.Keys.OfType<object>().Aggregate((a,b) => $"{a}, {b}").ToString());
            return View("SignIn", new HomeModel());
        }
    }
}