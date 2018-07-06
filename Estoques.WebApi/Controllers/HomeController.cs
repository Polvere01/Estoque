using System.Collections.Generic;
using System.Web.Http;

namespace Estoques.WebApi.Controllers
{
    [RoutePrefix("api")]
    public class HomeController : ApiController
    {
        [Route(""), HttpGet]
        public IEnumerable<string> Index()
        {
            return new string[] { "1", "2" };
        }
    }
}