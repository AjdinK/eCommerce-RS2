using eCommerce.Model;
using eCommerce.Services;
using Microsoft.AspNetCore.Mvc;

namespace eCommerceWebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase
{
    protected readonly IProductService _productService;

    public ProductController(IProductService productService)
    {
        _productService = productService;
    }

    [HttpGet("")]
    public List<Product> Get()
    {
        return _productService.Get();
    }

    [HttpGet("id")]
    public Product Get(int id)
    {
        return _productService.Get(id);
    }
}