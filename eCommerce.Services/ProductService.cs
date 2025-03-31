using eCommerce.Model;

namespace eCommerce.Services;

public class ProductService : IProductService
{
    public List<Product> Get(ProductSearchObject? search)
    {
        var products = new List<Product>
        {
            new()
            {
                Id = 1,
                Name = "Lenovo Laptop",
                Code = "1234"
            },
            new()
            {
                Id = 2,
                Name = "Macbook Pro",
                Code = "5678"
            }
        };

        var query = products.AsQueryable();

        if (!string.IsNullOrWhiteSpace(search?.FTS))
            query = query.Where(x =>
                x.Code.Contains(search.FTS, StringComparison.CurrentCultureIgnoreCase) ||
                x.Name.Contains(search.FTS, StringComparison.CurrentCultureIgnoreCase));

        if (!string.IsNullOrWhiteSpace(search?.Code))
            query = query.Where(x => x.Code == search.Code);

        if (!string.IsNullOrWhiteSpace(search?.CodeGTE))
            query = query.Where(x => x.Code.StartsWith(search.CodeGTE));

        return query.ToList();
    }

    public Product Get(int id)
    {
        return Get(null).FirstOrDefault(x => x.Id == id)
               ?? throw new InvalidOperationException();
    }
}