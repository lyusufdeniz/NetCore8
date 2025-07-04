using App.Services;
using App.Services.Products;
using Microsoft.AspNetCore.Mvc;

namespace App.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController(IProductService productService) : ControllerBase
    {
        [HttpGet]
        public async Task<ServiceResult<List<ProductResponse>>> ProductResponse()
        {
            return await productService.GetTopPriceProductsAsync(5);
        }
        [HttpPost]
        public async Task<ServiceResult<CreateProductResponse>> CreateProduct(CreateProductRequest request)
        {

            return await productService.CreateProductAsync(request);
        }

    }
}
