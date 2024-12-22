using Microsoft.AspNetCore.Mvc;

namespace Rusuz.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult<string> Get() =>
             Ok("Hello, Marion");
    }
}
