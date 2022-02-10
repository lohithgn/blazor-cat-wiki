using BlazorCatWiki.Shared.ServiceClients;
using BlazorCatWiki.Shared.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Refit;

namespace BlazorCatWiki.Shared.Extensions
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddCatWikiService(this IServiceCollection services)
        {
            services.AddSingleton<IStorageService, StorageService>();

            services.AddRefitClient<ICatServiceClient>()
                .ConfigureHttpClient((sp,c) => {
                    var config = sp.GetRequiredService<IConfiguration>();
                    c.BaseAddress = new Uri(config["CatWiki:Url"]);
                });    
            services.AddScoped<ICatWikiService, CatWikiService>();

            return services;
        }
    }
}
