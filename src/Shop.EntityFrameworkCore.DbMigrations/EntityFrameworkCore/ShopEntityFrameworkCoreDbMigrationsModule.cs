﻿using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace Shop.EntityFrameworkCore
{
    [DependsOn(
        typeof(ShopEntityFrameworkCoreModule)
        )]
    public class ShopEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<ShopMigrationsDbContext>();
        }
    }
}
