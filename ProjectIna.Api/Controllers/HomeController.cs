using Microsoft.AspNetCore.Mvc;

namespace ProjectIna.Controllers
{
[ApiController]
[Route("api/[controller]")]
    public class HomeController : Controller
    {
        public string Hello()
        {
            return "hello wolrd";
        }
    }
}