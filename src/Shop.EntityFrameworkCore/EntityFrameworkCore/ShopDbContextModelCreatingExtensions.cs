using Microsoft.EntityFrameworkCore;
using Shop.Books;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Shop.EntityFrameworkCore
{
    public static class ShopDbContextModelCreatingExtensions
    {
        public static void ConfigureShop(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(ShopConsts.DbTablePrefix + "YourEntities", ShopConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});

            builder.Entity<Book>(b=>
            {
                b.ToTable(ShopConsts.DbTablePrefix + "Books" + ShopConsts.DbSchema);
                b.ConfigureByConvention();
                b.Property(x => x.Name).IsRequired().HasMaxLength(128);
            });
        }
    }
}