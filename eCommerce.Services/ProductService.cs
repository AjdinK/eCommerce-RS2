using eCommerce.Model;

namespace eCommerce.Services;

public class ProductService : IProductService
{
    public List<Product> Get()
    {
        return
        [
            new Product()
            {
                Id = 1,
                Name = "Product 1",
                Code = "1234"
            },

            new Product()
            {
                Id = 2,
                Name = "Product 2",
                Code = "5678"
            }
        ];
    }

    public Product Get(int id)
    {
        return Get().FirstOrDefault(x => x.Id == id)
               ?? throw new InvalidOperationException();
    }
}