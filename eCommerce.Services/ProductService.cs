using System;
using System.Collections.Generic;
using System.Linq;
using eCommerce.Model;

namespace eCommerce.Services
{
    public class ProductService : IProductService
    {
        public List<Product> Get(ProductSearchObject? searchObject)
        {
            var products = new List<Product>
            {
                new Product
                {
                    Id = 1,
                    Name = "Lenovo Laptop",
                    Code = "1234"
                },
                new Product
                {
                    Id = 2,
                    Name = "Apple Macbook",
                    Code = "5678"
                }
            };

            var query = products.AsQueryable();

            if (!string.IsNullOrWhiteSpace(searchObject?.Code))
                query = query.Where(x => x.Code == searchObject.Code);

            if (!string.IsNullOrWhiteSpace(searchObject?.Code))
                query = query.Where(x => x.Code.Contains(searchObject.Code, StringComparison.CurrentCultureIgnoreCase));

            if (!string.IsNullOrWhiteSpace(searchObject?.FTS))
                query = query.Where(x => x.Name.Contains(searchObject.FTS, StringComparison.CurrentCultureIgnoreCase));

            return query.ToList();
        }


        public Product Get(int id)
        {
            return Get(null).FirstOrDefault(x => x.Id == id) ??
                   throw new Exception("Product not found");
        }
    }
}