using Microsoft.AspNetCore.Mvc;

namespace Citadel.API.Controllers
{
    [Route("/")]
    public class HomeController : Controller
    {

        [HttpGet]
        public ActionResult Index()
        {
            return new OkObjectResult("Citadel Group Technical Challenge API is up and running!");
        }
    }
}
