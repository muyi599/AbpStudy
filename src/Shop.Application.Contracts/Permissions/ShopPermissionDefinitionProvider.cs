using Shop.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Shop.Permissions
{
    public class ShopPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var shopGroup = context.AddGroup(ShopPermissions.GroupName,L("Permission:Shop"));

            //Define your own permissions here. Example:
            //myGroup.AddPermission(ShopPermissions.MyPermission1, L("Permission:MyPermission1"));

            var booksPermission = shopGroup.AddPermission(ShopPermissions.Books.Default, L("Permission:Books"));
            booksPermission.AddChild(ShopPermissions.Books.Create, L("Permission:Books.Create"));
            booksPermission.AddChild(ShopPermissions.Books.Edit, L("Permission:Books.Edit"));
            booksPermission.AddChild(ShopPermissions.Books.Delete, L("Permission:Books.Delete"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<ShopResource>(name);
        }
    }
}
