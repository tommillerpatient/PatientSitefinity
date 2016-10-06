using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using Telerik.Sitefinity.Web;

namespace SitefinityWebApp.Mvc.Helpers
{
    public static class HtmlHelpers
    {

        public static string IsSelected(this HtmlHelper html, string url, string cssClass = null)
        {
            if (String.IsNullOrEmpty(cssClass))
                cssClass = "active";

            var currentNode = SiteMapBase.GetActualCurrentNode();

            return currentNode.UrlName == url ?  cssClass : String.Empty;
        }


    }
}
