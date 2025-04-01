using System.Collections.Generic;
using eCommerce.Model;

namespace eCommerce.Services
{
    public interface IProductService
    {
        public List<Product> Get(ProductSearchObject? searchObject);
        public Product Get(int id);
    }
}