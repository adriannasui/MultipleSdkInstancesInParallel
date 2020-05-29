using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
namespace SampleSdk
{
    public static class SampleSdkServiceCollection
    {
        public static IServiceCollection AddSampleSdkClientServices<T>(this IServiceCollection services, IConfiguration configurationSection)
        {
            services.AddScoped<SampleSdkClient<T>>();
            services.Configure<SampleSdkConfig<T>>(configurationSection.GetSection("SampleSdkClient"));

            return services;
        }
        public static IServiceCollection AddSampleSdkClientServices(this IServiceCollection services, IConfiguration configurationSection)
        {
            services.AddScoped<SampleSdkClient>();
            services.Configure<SampleSdkConfig>(configurationSection.GetSection("SampleSdkClient"));

            return services;
        }
    }
}
