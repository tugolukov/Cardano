using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Cardano.Abstractions.Models;
using Cardano.Abstractions.Models.Client;
using Cardano.Abstractions.Models.Contexts;
using Cardano.Abstractions.Services;
using Cardano.Entities;
using Cardano.Entities.Wallets;
using Cardano.Utils.HttpClient.Extensions;

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
        public async Task<Response<List<WalletAddress>>> GetAll(AddressesContext context) =>
            await _client.GetAsync<Response<List<WalletAddress>>>($"/api/v1/addresses?page={context.Page}?per_page={context.PerPage}");

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
        public async Task<Response<WalletAddress>> Get(AddressesContext context) =>
            await _client.GetAsync<Response<WalletAddress>>($"/api/v1/addresses/{context.Address}");

        /// <inheritdoc />
        public async Task<Response<BatchImportResult>> Import(string walletId, List<string> addresses) =>
            await _client.PostAsync<Response<BatchImportResult>>($"/api/v1/wallets/{walletId}/addresses", new
            {
                addresses
            });
    }
}