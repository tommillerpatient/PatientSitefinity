using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SitefinityWebApp.Data;

namespace SitefinityWebApp.Mvc.Helpers
{
    public class UserContext
    {

        public static bool Login(string email, string password)
        {
            var passkey = string.Concat(email, password).GetKey();
            //var passkey = password;
            using (var model = new MasterPatientIndexDevEntities())
            {
                var user = model.People.SingleOrDefault(p => p.PasswordHash == passkey);
                if (user != null)
                {
                    SetToken(user.SessionToken);
                    return true;
                }
                return false;
            }
        }

        public static void Logout()
        {
            SetToken(null);
            HttpContext.Current.Items[GlobalKeys.ContextKey] = null;
        }

        public static string GetToken()
        {
            HttpCookie cookie = HttpContext.Current.Request.Cookies[GlobalKeys.Token];
            if (cookie != null)
            {
                return cookie.Value;
            }

            return string.Empty;
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

                    var token = GetToken();

                    if (!string.IsNullOrEmpty(token))
                    {
                        using (var model = new MasterPatientIndexDevEntities())
                        {
                            var user = model.People.SingleOrDefault(p => p.SessionToken == token);
                            if(user != null)
                            {
                                context.UserId = user.Id;
                                context.UserEmail = user.Email;
                                context.Roles = new HashSet<string>();
                                context.Roles.Add(model.Roles.Single(r => r.RoleId == user.roleid).Type);
                            }
                        }
                    }

                    HttpContext.Current.Items[GlobalKeys.ContextKey] = context;
                }
                return context;
            }
        }

        public static bool IsUserInRole(string role)
        {
            return Current.Roles.Contains(role);
        }

        public static bool IsAuthenticated => !string.IsNullOrEmpty(Current.UserEmail);

        public static int CurrentUserId => Current.UserId;


        public int UserId { get; set; }

        public string UserEmail { get; set; }

        public HashSet<string> Roles { get; set; }
    }
}