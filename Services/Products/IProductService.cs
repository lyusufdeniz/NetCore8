using App.Repositories;
using App.Repositories.Products;
namespace App.Services.Products

{
    public interface IProductService
    {
        public Task<ServiceResult<List<Product>>> GetTopPriceProductsAsync(int count);
    }
}
