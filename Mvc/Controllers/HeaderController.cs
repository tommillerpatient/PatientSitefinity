using System;
using System.ComponentModel;
using System.Linq;
using System.Web.Mvc;
using Telerik.Sitefinity.Mvc;
using SitefinityWebApp.Mvc.Helpers;
using Telerik.Sitefinity.Modules.Pages;
using Telerik.Sitefinity.Pages.Model;
using Telerik.Sitefinity;
using Telerik.Sitefinity.Web.UI.NavigationControls;
using Telerik.Sitefinity.Web;

namespace SitefinityWebApp.Mvc.Controllers
{
    [ControllerToolboxItem(Name = "Header", Title = "Header", SectionName = "LayoutWidgets")]
    public class HeaderController : Controller
    {
        /// <summary>
        /// This is the default Action.
        /// </summary>
        public ActionResult Index()
        {
            //try
            //{
            //    var currentNode = SiteMapBase.GetActualCurrentNode();

            //    var pageManager = PageManager.GetManager();
            //    //EmptyTemplate
            //    var template = pageManager.GetTemplates().Single(t => t.Name == "EmptyTemplate");
            //    var message = "";
            //    PageData active;
            //    var r = Request;
            //    foreach (var item in template.Pages())
            //    {
            //        try
            //        {
            //            var t = item;
            //            if(t.UrlName.Value == "home")
            //            {
            //                active = t;
            //            }
            //            message += t.UrlName.Value;
            //        }
            //        catch (Exception)
            //        {
            //        }
                    
            //    }
            //    DebugHelper.SetMessage(message);
            //}
            //catch (Exception e)
            //{
            //    DebugHelper.SetMessage(e.GetBaseException().Message);
            //}
            
            return View("Default");
        }
    }
}