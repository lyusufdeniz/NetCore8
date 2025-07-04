using App.Repositories.Products;
using System.Net;
namespace App.Services.Products
{
    public class ProductService(IProductRepository repository) : IProductService
    {
        public async Task<ServiceResult<List<Product>>> GetTopPriceProductsAsync(int count)
        {
         return   ServiceResult<List<Product>>.Succes(await repository.GetTopPriceProductsAsync(count),HttpStatusCode.OK);

        }

    }
}
