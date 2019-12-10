using System;
using Cardano.Abstractions.Models;
using Cardano.Abstractions.Services;
using Cardano.Core.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Cardano.Core.Extensions
{
    /// <summary />
    public static class ServicesExtensions
    {
        /// <summary />
        public static IServiceCollection AddCardanoCore(this IServiceCollection services, Action<ConnectionOptions> options)
        {
            services.AddOptions(options);
            
            services.AddScoped<IAccountsService, AccountsService>();
            services.AddScoped<IAddressesService, AddressesService>();
            services.AddScoped<IInformationsService, InformationsService>();
            services.AddScoped<IInternalService, InternalService>();
            services.AddScoped<ISettingsService, SettingsService>();
            services.AddScoped<ITransactionsService, TransactionsService>();
            services.AddScoped<IWalletsService, WalletsService>();

            return services;
        }
        
        /// <summary>
        /// Добавление настроек
        /// </summary>
        /// <param name="services"></param>
        /// <param name="setup"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        private static IServiceCollection AddOptions<T>(this IServiceCollection services, Action<T> setup)
            where T : class, new()
        {
            var options = new T();
            setup?.Invoke(options);

            services.AddSingleton(options);

            return services;
        } 
    }
}