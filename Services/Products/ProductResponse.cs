namespace App.Services.Products
{
    public record ProductResponse(int Id ,string Name,string Description , Decimal Price, int Stock);

}
