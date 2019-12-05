using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Cardano.Abstractions.Models;
using Cardano.Abstractions.Models.Client;
using Cardano.Abstractions.Services;
using Cardano.Core.Extensions;
using Cardano.Entities;

namespace Cardano.Core.Services
{
    /// <inheritdoc />
    public class AddressesService : IAddressesService
    {
        private readonly HttpClient _client;

        /// <inheritdoc />
        public AddressesService(ConnectionOptions options)
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri(options.Url);
        }

        /// <inheritdoc />
        public async Task<Response<List<WalletAddress>>> GetAll(int page = 1, int perPage = 10) =>
            await _client.GetAsync<Response<List<WalletAddress>>>($"/api/v1/addresses?page={page}?per_page={perPage}");

        /// <inheritdoc />
        public async Task<Response<WalletAddress>> Create(ulong accountIndex, string walletId,
            string spendingPassword = "") =>
            await _client.PostAsync<Response<WalletAddress>>("/api/v1/addresses", new
            {
                AccountIndex = accountIndex,
                WalletId = walletId,
                SpendingPassword = spendingPassword
            });

        /// <inheritdoc />
        public async Task<Response<WalletAddress>> Get(string address) =>
            await _client.GetAsync<Response<WalletAddress>>($"/api/v1/addresses/{address}");

        /// <inheritdoc />
        public async Task<Response<BatchImportResult>> Import(string walletId, List<string> addresses) =>
            await _client.PostAsync<Response<BatchImportResult>>($"/api/v1/wallets/{walletId}/addresses", new
            {
                addresses
            });
    }
}