using BlazingShop.Client.Services.CategoryService;
using Microsoft.AspNetCore.Components;

namespace BlazingShop.Client.Shared
{
    public partial class NavMenu
    {
        [Inject]
        private ICategoryService CategoryService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await CategoryService.LoadCategories();
        }
    }
}
