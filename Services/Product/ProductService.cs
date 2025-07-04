using App.Repositories.Product;

namespace App.Services.Product
{
    public class ProductService(IProductRepository repository) : IProductService
    {
        public Task<List<Repositories.Product.Product>> GetTopPriceProductsAsync(int count) => repository.GetTopPriceProductsAsync(count);

    }
}
