using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitefinityWebApp.Mvc.Helpers
{
    public static class DebugHelper
    {
        public static string GetMessage()
        {
            return HttpContext.Current.Items[GlobalKeys.DebugMessageKey] as string;
        }

        public static void SetMessage(string message)
        {
            var existMessage = GetMessage();
            if (!string.IsNullOrEmpty(existMessage))
            {
                message = string.Format("{0}<br>{1}", GetMessage(), message);
            }
            HttpContext.Current.Items[GlobalKeys.DebugMessageKey] = message;
        }
    }
}