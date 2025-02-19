using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace WebApi1.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        public static List<Product> Products { get; set; } = new();

        [HttpPost]
        public IActionResult CreateProduct(Product request)
        {
            Products.Add(request);
            return Created();
        }

        [HttpGet]
        public IActionResult GetProducts()
        {
            return Ok(Products);
        }
    }
}
