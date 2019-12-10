using System;
using Cardano.Abstractions.Models;
using Cardano.Abstractions.Services;
using Cardano.Core.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Cardano.Core.Extensions
{
    public static class ServicesExtensions
    {
        public static IServiceCollection AddCardanoCore(this IServiceCollection services, Action<ConnectionOptions> options)
        {
            services.AddScoped<IAccountsService, AccountsService>();
            services.AddScoped<IAddressesService, AddressesService>();
            services.AddScoped<IInformationsService, InformationsService>();
            services.AddScoped<IInternalService, InternalService>();
            services.AddScoped<ISettingsService, SettingsService>();
            services.AddScoped<ITransactionsService, TransactionsService>();

            return services;
        }
    }
}