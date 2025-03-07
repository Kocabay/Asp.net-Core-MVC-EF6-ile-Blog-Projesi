using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using YoutubeBlog.Service.Services.Abstrations;
using YoutubeBlog.Service.Services.Concrete;

namespace YoutubeBlog.Service.Extensions
{
    public static class ServiceLayerExtensions
    {
        public static IServiceCollection LoadServiceLayerExtension(this IServiceCollection services)
        {
            services.AddScoped<IArticleService, ArticleService>();

            return services;
        }
    }
}
