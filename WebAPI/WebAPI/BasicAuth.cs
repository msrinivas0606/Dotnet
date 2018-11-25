using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;
using System.Threading;
using System.Security.Principal;

namespace WebAPI
{
    public class BasicAuth : AuthorizationFilterAttribute
    {
        public override void OnAuthorization(HttpActionContext actionContext)
        {
            if (actionContext.Request.Headers.Authorization == null)
            {
                actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.Unauthorized);
            }
            else
            {
                string authToken = actionContext.Request.Headers.Authorization.Parameter;
                string decode = Encoding.UTF8.GetString(Convert.FromBase64String(authToken));
                string[] output = decode.Split(':');
                if (EmpSecurity.Login(output[0], output[1]))
                    Thread.CurrentPrincipal = new GenericPrincipal(new GenericIdentity(output[0]), null);
                else
                    actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.Unauthorized);

            }
        }
    }
}