using System;
using System.ComponentModel;
using System.Linq;
using System.Web.Mvc;
using Telerik.Sitefinity.Mvc;
using SitefinityWebApp.Mvc.Models;

namespace SitefinityWebApp.Mvc.Controllers
{
    [ControllerToolboxItem(Name = "ContactPhysician", Title = "ContactPhysician", SectionName = "MvcWidgets")]
    public class ContactPhysicianController : Controller
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
            var model = new ContactPhysicianModel();
            if (string.IsNullOrEmpty(this.Message))
            {
                model.Message = "ContactPhysician";
            }
            else
            {
                model.Message = this.Message;
            }

            return View("Default", model);
        }
    }
}