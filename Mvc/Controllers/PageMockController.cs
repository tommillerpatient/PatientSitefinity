using System;
using System.ComponentModel;
using System.Linq;
using System.Web.Mvc;
using Telerik.Sitefinity.Mvc;
using SitefinityWebApp.Mvc.Models;
using Telerik.Sitefinity.Web;

namespace SitefinityWebApp.Mvc.Controllers
{
    [ControllerToolboxItem(Name = "PageMock", Title = "PageMock", SectionName = "MvcWidgets")]
    public class PageMockController : Controller
    {
        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        [Category("String Properties")]
        public string Message { get; set; }

        /// <summary>
        /// This is the default Action.
        /// </summary>
        public ActionResult Index()
        {
            var model = new PageMockModel();
            try
            {

                var currentNode = SiteMapBase.GetActualCurrentNode();
                model.Message = currentNode.Title;

            }
            catch (Exception)
            {
                
            }

            return View("Default", model);
        }
    }
}