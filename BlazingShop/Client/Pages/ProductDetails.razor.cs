using BlazingShop.Client.Services.ProductService;
using BlazingShop.Shared;
using Microsoft.AspNetCore.Components;

namespace BlazingShop.Client.Pages
{
    public partial class ProductDetails
    {
        private IProductService ProductService { get; set; }

        private Product product = new Product();

        private int currentEditionId = 1;

        //private CartItem cartItem = new CartItem { Quantity = 1 };

        [Parameter]
        public int Id { get; set; }

        protected override void OnInitialized()
        {
            if (ProductService.Products == null || ProductService.Products.Count == 0)
            {
                ProductService.LoadProducts();
            }

            product = ProductService.Products.FirstOrDefault(p => p.Id == Id);
        }


        //protected override async Task OnParametersSetAsync()
        //{
        //    product = await ProductService.GetProduct(Id);
        //    if (product.Variants.Count > 0)
        //    {
        //        currentEditionId = product.Variants[0].EditionId;
        //    }
        //}

        //private ProductVariant GetSelectedVariant()
        //{
        //    var variant = product.Variants.FirstOrDefault(v => v.EditionId == currentEditionId);
        //    return variant;
        //}

        //private async Task AddToCart()
        //{
        //    var productVariant = GetSelectedVariant();

        //    cartItem.EditionId = productVariant.EditionId;
        //    cartItem.EditionName = productVariant.Edition.Name;
        //    cartItem.Image = product.Image;
        //    cartItem.Price = productVariant.Price;
        //    cartItem.ProductId = productVariant.ProductId;
        //    cartItem.ProductTitle = product.Title;

        //    await CartService.AddToCart(cartItem);
        //}

        //private string GetViewString()
        //{
        //    if (product.Views > 1000000)
        //        return $"{((float)product.Views / 1000000).ToString("#.##")}M";
        //    if (product.Views > 100000)
        //        return $"{((float)product.Views / 1000).ToString("#")}K";
        //    if (product.Views > 1000)
        //        return $"{((float)product.Views / 1000).ToString("#.##")}K";

        //    return product.Views.ToString("0##");
        //}
    }
}
