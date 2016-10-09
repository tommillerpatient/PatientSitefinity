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
            try
            {
                if (string.IsNullOrEmpty(cssClass)) cssClass = "active";

                var currentNode = SiteMapBase.GetActualCurrentNode();

                return url.Contains(currentNode.UrlName) ? cssClass : string.Empty;
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }
    }
}
