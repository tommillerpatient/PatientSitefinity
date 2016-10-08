using System;
using System.Linq;

namespace SitefinityWebApp.Mvc.Models
{
    public class AuthorizationModel
    {
        public string AuthorizationUrl { get; set; }
        public string UnauthorizationUrl { get; set; }
    }
}