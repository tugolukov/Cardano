using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Cardano.Abstractions.Models;
using Cardano.Abstractions.Models.Client;
using Cardano.Abstractions.Models.Contexts;
using Cardano.Abstractions.Models.Requests;
using Cardano.Abstractions.Services;
using Cardano.Entities.Wallets;
using Cardano.Utils.HttpClient.Extensions;

namespace Cardano.Core.Services
{
    /// <inheritdoc />
    public class WalletsService : IWalletsService
    {
        private readonly HttpClient _client;

        /// <inheritdoc />
        public WalletsService(ConnectionOptions options)
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri(options.Url);
        }

        /// <inheritdoc />
        public async Task<Response<List<Wallet>>> GetAll(WalletsContext context) =>
            await _client.GetAsync<Response<List<Wallet>>>("/api/v1/wallets", context);

        /// <inheritdoc />
        public async Task<Response<Wallet>> Create(WalletsRequest body) =>
            await _client.PostAsync<Response<Wallet>>("/api/v1/wallets", body);

        /// <inheritdoc />
        public async Task Delete(string walletId) =>
            await _client.DeleteVoidAsync($"/api/v1/wallets/{walletId}");

        /// <inheritdoc />
        public async Task<Response<Wallet>> Get(string walletId) =>
            await _client.GetAsync<Response<Wallet>>($"/api/v1/wallets/{walletId}");

        /// <inheritdoc />
        public async Task<Response<Wallet>> Update(string walletId, string assuranceLevel, string name) =>
            await _client.PutAsync<Response<Wallet>>($"/api/v1/wallets/{walletId}", new
            {
                AssuranceLevel = assuranceLevel,
                Name = name
            });

        /// <inheritdoc />
        public async Task<Response<Wallet>> UpdatePassword(string walletId, string oldPassword, string newPassword) =>
            await _client.PutAsync<Response<Wallet>>($"/api/v1/wallets/{walletId}/password", new
            {
                NewPassword = newPassword,
                OldPassword = oldPassword
            });

        /// <inheritdoc />
        public async Task<Response<UtxoStatistics>> GetUtxo(string walletId) =>
            await _client.GetAsync<Response<UtxoStatistics>>($"/api/v1/wallets/{walletId}/statistics/utxos");
    }
}