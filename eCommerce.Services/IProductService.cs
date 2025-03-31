using eCommerce.Model;

namespace eCommerce.Services;

public interface IProductService
{
    public List<Product> Get(ProductSearchObject search);
    public Product Get(int id);
}