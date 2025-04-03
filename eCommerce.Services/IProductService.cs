﻿using eCommerce.Model;
using eCommerce.Model.SearchObjects;
using eCommerce.Model.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Services
{
    public interface IProductService
    {
        Task<List<ProductResponse>> GetAsync(ProductSearchObject search);
        Task<ProductResponse?> GetByIdAsync(int id);
    }
}
