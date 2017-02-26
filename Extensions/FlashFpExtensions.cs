using FlashFP;
using FlashFP.Storage;
using FlashFPService.Services;
using Microsoft.Extensions.Configuration;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class FlashFpExtensions
    {
        public static IServiceCollection AddInMemoryFlashFp(this IServiceCollection services,
                                                            IConfiguration flashConfig,
                                                            IConfiguration storageConfig)
        {
            services.AddSingleton<IStorage, InMemoryStorage>();
            services.Configure<InMemoryStorageOptions>(storageConfig);

            services.AddTransient<FlashFp, FlashFpService>();
            services.Configure<FlashConfig>(flashConfig);

            return services;
        }
    }
}