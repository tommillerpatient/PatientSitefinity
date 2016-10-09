using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SitefinityWebApp.Api.Models;
using SitefinityWebApp.Mvc.Helpers;

namespace SitefinityWebApp.Api.Controllers
{
    public class AccountController : ApiController
    {
        [HttpPost]
        public HttpResponseMessage Login([FromBody] CredentialModel data)
        {
            return Request.CreateResponse(HttpStatusCode.OK, new { Ok = UserContext.Login(data.Email, data.Password) });
        }

        [HttpDelete]
        public HttpResponseMessage Logout()
        {
            UserContext.Logout();
            return Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}
