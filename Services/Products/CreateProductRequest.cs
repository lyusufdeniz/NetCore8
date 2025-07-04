

namespace App.Services.Products
{
    public record CreateProductRequest(string Name, string Description, Decimal Price, int Stock)
    {
    }
}
