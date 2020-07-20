using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Components;
using Volo.Abp.DependencyInjection;

namespace Shop.Web
{
    [Dependency(ReplaceServices = true)]
    public class ShopBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "Shop";
    }
}
