using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication.Controllers
{
    public class UsersController : ApiController
    {
        public HttpResponseMessage Login(string userName, string password)
        {
            return new HttpResponseMessage(HttpStatusCode.OK);
        }
    }
}