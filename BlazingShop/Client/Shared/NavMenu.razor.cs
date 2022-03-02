using BlazingShop.Client.Services.CategoryService;

namespace BlazingShop.Client.Shared
{
    public partial class NavMenu
    {
        private ICategoryService CategoryService { get; set; } = new CategoryService();

        protected override void OnInitialized()
        {
            CategoryService.LoadCategories();
        }

    }
}
