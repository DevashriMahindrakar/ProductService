using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/products")]
public class ProductsController : ControllerBase
{
    [HttpGet]
    [Authorize]
    public IActionResult GetProducts() => Ok(new[] { "Product1", "Product2" });

    [HttpPost]
    [Authorize(Roles = "User")]
    public IActionResult CreateProduct([FromBody] string product) => Ok($"Product {product} created");
}