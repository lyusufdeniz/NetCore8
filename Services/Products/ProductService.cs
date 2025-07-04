using App.Repositories;
using App.Repositories.Products;
using System.Net;
using System.Runtime.InteropServices;
namespace App.Services.Products
{
    public class ProductService(IProductRepository repository,IUnitOfWork unitOfWork) : IProductService
    {
        public  async Task<ServiceResult<CreateProductResponse>> CreateProductAsync(CreateProductRequest request)
        {
            var product=new Product()
            {
                Description = request.Description,
                Name = request.Name,
                Price = request.Price,
                Stock = request.Stock,
            };
          await  repository.AddAsync(product);
        await    unitOfWork.SaveChangesAsync();
            return ServiceResult<CreateProductResponse>.Succes(new CreateProductResponse(product.Id));
        }

        public async Task<ServiceResult<List<ProductResponse>>> GetTopPriceProductsAsync(int count)

        {
            var products = await repository.GetTopPriceProductsAsync(count);
            var productsAsDto = products.Select(p => new ProductResponse(p.Id, p.Name, p.Description,  p.Price*1.20m, p.Stock )).ToList(); 

            return   ServiceResult<List<ProductResponse>>.Succes(productsAsDto,HttpStatusCode.OK);

        }

    }
}
