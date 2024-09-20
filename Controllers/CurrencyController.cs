using Microsoft.AspNetCore.Mvc;
namespace TestApi.Controllers
{
   [ApiController]
    [ApiVersion("1.0")]
    [ApiVersion("2.0")]
    [Route("api/v{version:apiVersion}/[controller]")]

    public class CurrencyController : Controller
    {
        [HttpGet]
        [MapToApiVersion("1")]
        public IActionResult Get1(string name)
        {
            return Ok("Ok from 1");
        }

         [HttpGet]
         [MapToApiVersion("2")]
        public IActionResult Get2(string name)
        {
            return Ok("Ok from 2");
        }

        [HttpPost]

        public IActionResult Post(string name)
        {
            return Ok("Ok from Post");
        }
    }
}