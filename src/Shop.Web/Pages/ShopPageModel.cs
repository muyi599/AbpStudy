using Shop.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Shop.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class ShopPageModel : AbpPageModel
    {
        protected ShopPageModel()
        {
            LocalizationResourceType = typeof(ShopResource);
        }
    }
}