using Microsoft.EntityFrameworkCore;

namespace App.Repositories.Product
{
    public class ProductRepository(AppDbContext context) : GenericRepository<Product>(context), IProductRepository
    {
        public  Task<List<Product>> GetTopPriceProductsAsync(int count)
        {
            return  Context.Products.OrderByDescending(x=>x.price).Take(count).ToListAsync();
        }
    }
}
