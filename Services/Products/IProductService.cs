namespace App.Services.Products

{
    public interface IProductService
    {
        public Task<ServiceResult<List<ProductResponse>>> GetTopPriceProductsAsync(int count);
        public Task<ServiceResult<CreateProductResponse>> CreateProductAsync(CreateProductRequest request);
    }
}
