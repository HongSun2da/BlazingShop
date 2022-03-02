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

        [Inject]
        public ICategoryService CategoryService { get; set; }

        //protected override void OnInitialized()
        //{

        //}

        protected override async Task OnParametersSetAsync()
        {
            await CategoryService.LoadCategories();

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
