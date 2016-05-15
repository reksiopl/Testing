using System.Web.Http;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class OrderController : ApiController
    {
        [HttpPost]
        public Order SendOrder([FromBody]Order order)
        {
            order.id = 1;
            return order;
        }
    }
}
