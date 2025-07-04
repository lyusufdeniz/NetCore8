namespace App.Services.Product
{
    public interface IProductService
    {
        public Task<List<Repositories.Product.Product>> GetTopPriceProductsAsync(int count);
    }
}
