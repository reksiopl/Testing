using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class UsersController : ApiController
    {
        [HttpPost]
        public HttpResponseMessage Login([FromBody]User user)
        {
            var a = HttpContext.Current.User;
            return new HttpResponseMessage(HttpStatusCode.OK);
        }
    }
}