using System;
using System.ComponentModel;
using System.Linq;
using System.Web.Mvc;
using Telerik.Sitefinity.Mvc;
using SitefinityWebApp.Mvc.Models;
using SitefinityWebApp.Mvc.Helpers;
using Telerik.Sitefinity.Modules.Pages;
using Telerik.Sitefinity.Pages.Model;
using Telerik.Sitefinity;

namespace SitefinityWebApp.Mvc.Controllers
{
    [ControllerToolboxItem(Name = "Header", Title = "Header", SectionName = "MvcWidgets")]
    public class HeaderController : Controller
    {
        /// <summary>
        /// This is the default Action.
        /// </summary>
        public ActionResult Index()
        {
            try
            {
                var pageManager = PageManager.GetManager();
                //EmptyTemplate
                var template = pageManager.GetTemplates().Single(t => t.Name == "EmptyTemplate");
                foreach (var item in template.Pages())
                {
                    var t = item;
                }
                //var message = template.Pages().Where(p => !p.IsDeleted).Select(p => pageManager.GetPageNode(p.Id).Name).Aggregate((a,b) => a + ", " + b);
                DebugHelper.SetMessage("");
            }
            catch (Exception e)
            {
                DebugHelper.SetMessage(e.GetBaseException().Message);
            }
            
            return View("Default", new HeaderModel());
        }
    }
}