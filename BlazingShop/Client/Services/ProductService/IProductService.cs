using BlazingShop.Shared;

namespace BlazingShop.Client.Services.ProductService
{
    public interface IProductService
    {
        event Action OnChange;
        List<Product> Products { get; set; }
        void LoadProducts();

        //Task LoadProducts(string? categoryUrl = null);
        //Task<Product> GetProduct(int id);
        //Task<List<Product>> SearchProducts(string searchText);

    }
}
