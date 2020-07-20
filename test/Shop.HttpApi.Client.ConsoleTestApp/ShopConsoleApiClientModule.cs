﻿using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Shop.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(ShopHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class ShopConsoleApiClientModule : AbpModule
    {
        
    }
}
