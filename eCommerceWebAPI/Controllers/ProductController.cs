using eCommerce.Model;
using Microsoft.AspNetCore.Mvc;

namespace eCommerceWebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase
{
    [HttpGet]
    public IEnumerable<Product> Get()
    {
        List<Product> products =
        [
            new()
            {
                Id = 1,
                Name = "Product 1",
                Code = "1234"
            }
        ];
        return products;
    }
}