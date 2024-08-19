using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using OrchardCore.ResourceManagement;
using OrchardCore.Modules;
using Microsoft.AspNetCore.Mvc;
using BejzbolNet.MainTheme.Filters;

namespace BejzbolNet.MainTheme
{
    public class Startup : StartupBase
    {
        public override void ConfigureServices(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IConfigureOptions<ResourceManagementOptions>, ResourceManagementOptionsConfiguration>();

            serviceCollection.Configure<MvcOptions>(config =>
            {
                //config.Filters.Add<GenericFilter>();
            });
        }
    }
}
