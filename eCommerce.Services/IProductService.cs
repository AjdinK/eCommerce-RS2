using eCommerce.Model.Responses;
using eCommerce.Model.SearchObjects;

namespace eCommerce.Services;

public interface IProductService
{
    Task<List<ProductResponse>> GetAsync(ProductSearchObject search);
    Task<ProductResponse?> GetByIdAsync(int id);
}