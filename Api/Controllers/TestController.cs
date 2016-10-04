using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SitefinityWebApp.Api.Controllers
{
    public class TestController : ApiController
    {
        public string GetTestText()
        {
            return "Test succeeded";
        }
    }
}
