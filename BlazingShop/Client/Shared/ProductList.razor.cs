using BlazingShop.Client.Services.ProductService;
using BlazingShop.Shared;
using Microsoft.AspNetCore.Components;

namespace BlazingShop.Client.Shared
{
    public partial class ProductList
    {
        [Parameter]
        public int? CategoryId { get; set; } = null;

        private IProductService productService { get; set; } = new ProductService();

        protected override void OnInitialized()
        {
            productService.LoadProducts();
        }


        //public void Dispose()
        //{
        //    ProductService.OnChange -= StateHasChanged;
        //}

        //private string GetPriceText(Product product)
        //{
        //    var variants = product.Variants;
        //    if (variants.Count == 0)
        //    {
        //        return string.Empty;
        //    }
        //    else if (variants.Count == 1)
        //    {
        //        return $"${variants[0].Price}";
        //    }
        //    decimal minPrice = variants.Min(v => v.Price);
        //    return $"Starting at ${minPrice}";
        //}
    }
}
