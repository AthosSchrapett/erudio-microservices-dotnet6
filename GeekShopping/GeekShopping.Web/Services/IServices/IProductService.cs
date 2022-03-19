﻿using GeekShopping.Web.Models;

namespace GeekShopping.Web.Services
{
    public interface IProductService
    {
        Task<IEnumerable<ProductModel>> FindAllProducts();
        Task<ProductModel> FindProductById(long id);
        Task<ProductModel> CreateProduct(ProductModel model);
        Task<ProductModel> UpdateProduct(ProductModel model);
        Task<bool> DeleteProduct(long id);
    }
}
