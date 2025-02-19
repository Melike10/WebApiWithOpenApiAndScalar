using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi1.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public IActionResult Hello()
        {
            return Ok(new {Meesage = "Hello World!" });
        }

        [HttpPost]
        public IActionResult CreateProduct(Product request)
        {
            return StatusCode(200, new { Message = request.Name.ToString()+ " eklendi" });
        }


    }
    public class Product()
    {
        public string Name { get; set; }
    }
}
