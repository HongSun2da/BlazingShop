using BlazingShop.Client.Services.CategoryService;
using BlazingShop.Shared;
using Microsoft.AspNetCore.Components;

namespace BlazingShop.Client.Pages
{
    public partial class Index
    {
        [Parameter]
        public string CategoryUrl { get; set; }

        private Category? category = null;

        public ICategoryService CategoryService { get; set; } = new CategoryService();

        protected override void OnInitialized()
        {

        }

        protected override void OnParametersSet()
        {
            CategoryService.LoadCategories();

            if (CategoryUrl != null)
            {
                category = CategoryService.Categories.FirstOrDefault(c => c.Url.ToLower().Equals(CategoryUrl.ToLower()));
            }
            else
            {
                category = null;
            }
        }
    }
}
