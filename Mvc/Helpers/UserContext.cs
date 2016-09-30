using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Web;
using Newtonsoft.Json.Linq;

namespace SitefinityWebApp.Mvc.Helpers
{
    public class UserContext
    {

        public static string GetToken()
        {
            HttpCookie cookie = HttpContext.Current.Request.Cookies[GlobalKeys.Token];
            if (cookie != null)
            {
                return cookie.Value;
            }

            return String.Empty;
        }

        public static void SetToken(string token)
        {
            HttpContext.Current.Response.Cookies.Remove(GlobalKeys.Token);
            var cookie = new HttpCookie(GlobalKeys.Token);
            cookie.Value = token;
            cookie.Expires = DateTime.Now.AddYears(string.IsNullOrEmpty(token) ? -1 : 1);
            HttpContext.Current.Response.Cookies.Add(cookie);
        }

        public static UserContext Current
        {
            get
            {
                var context = HttpContext.Current.Items[GlobalKeys.ContextKey] as UserContext;
                if (context == null)
                {
                    context = new UserContext();
                    // to do init
                    HttpContext.Current.Items[GlobalKeys.ContextKey] = context;
                }
                return context;
            }
        }

        public static bool IsUserInRole(string role)
        {
            return Current.Roles.Contains(role);
        }

        public static bool IsAuthenticated => !String.IsNullOrEmpty(Current.UserName);

        public static int CurrentUserId => Current.UserId;


        public int UserId { get; set; }

        public string UserName { get; set; }

        public HashSet<string> Roles { get; set; }
    }
}