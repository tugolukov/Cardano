using System;
using System.Net.Http;
using System.Threading.Tasks;
using Cardano.Abstractions.Models;
using Cardano.Abstractions.Models.Client;
using Cardano.Abstractions.Services;
using Cardano.Core.Extensions;
using Cardano.Entities;
using Cardano.Entities.Settings;

namespace Cardano.Core.Services
{
    /// <inheritdoc />
    public class InternalService : IInternalService
    {
        private readonly HttpClient _client;

        /// <inheritdoc />
        public InternalService(ConnectionOptions options)
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri(options.Url);
        }

        /// <inheritdoc />
        public async Task ApplyNextUpdate() =>
            await _client.PostAsync("/api/internal/apply-update", null);

        /// <inheritdoc />
        public Task<Response<Wallet>> ImportWallet(string filePath, string spendingPassword) =>
            _client.PostAsync<Response<Wallet>>($"/api/internal/import-wallet", new
            {
                FilePath = filePath,
                SpendingPassword = spendingPassword
            });

        /// <inheritdoc />
        public async Task<Response<SoftwareInfo>> VersionOfTheNextUpdate() =>
            await _client.GetAsync<Response<SoftwareInfo>>($"/api/internal/next-update");

        /// <inheritdoc />
        public async Task DiscardAndPostpone() => 
            await _client.PostAsync($"/api/internal/postpone-update", null);

        /// <inheritdoc />
        public async Task ClearWallet() => 
            await _client.DeleteVoidAsync($"/api/internal/reset-wallet-state");
    }
}