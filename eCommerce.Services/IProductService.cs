using eCommerce.Model;

namespace eCommerce.Services;

public interface IProductService
{
    public List<Product> Get();
    public Product Get(int id);
}