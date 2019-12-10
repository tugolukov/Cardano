using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Cardano.Abstractions.Models;
using Cardano.Abstractions.Models.Client;
using Cardano.Abstractions.Models.Contexts;
using Cardano.Abstractions.Services;
using Cardano.Entities;
using Cardano.Utils.HttpClient.Extensions;

namespace Cardano.Core.Services
{
    /// <inheritdoc />
    public class AccountsService : IAccountsService
    {
        private readonly HttpClient _client;

        /// <inheritdoc />
        public AccountsService(ConnectionOptions options)
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri(options.Url);
        }

        /// <inheritdoc />
        public async Task<Response<List<Account>>> GetAll(AccountsContext context) =>
            await _client.GetAsync<Response<List<Account>>>($"/api/v1/wallets/{context.WalletId}/accounts");

        /// <inheritdoc />
        public async Task<Response<Account>> Create(string walletId, string name, string spendingPassword = "") =>
            await _client.PostAsync<Response<Account>>($"/api/v1/wallets/{walletId}/accounts", new
            {
                Name = name,
                SpendingPassword = spendingPassword
            });

        /// <inheritdoc />
        public async Task Delete(AccountsContext context) =>
            await _client.DeleteVoidAsync($"/api/v1/wallets/{context.WalletId}/accounts/{context.AccountId}");

        /// <inheritdoc />
        public async Task<Response<Account>> Get(AccountsContext context) =>
            await _client.GetAsync<Response<Account>>(
                $"/api/v1/wallets/{context.WalletId}/accounts/{context.AccountId}");

        /// <inheritdoc />
        public async Task<Response<Account>> Update(string walletId, string accountId, string name) =>
            await _client.PutAsync<Response<Account>>(
                $"/api/v1/wallets/{walletId}/accounts/{accountId}", new
                {
                    Name = name
                });

        /// <inheritdoc />
        public async Task<Response<List<WalletAddress>>> GetAddresses(AccountsContext context) =>
            await _client.GetAsync<Response<List<WalletAddress>>>(
                $"/api/v1/wallets/{context.WalletId}/accounts/{context.AccountId}/addresses");


        /// <inheritdoc />
        public async Task<Response<ulong>> GetBalance(AccountsContext context) =>
            await _client.GetAsync<Response<ulong>>(
                $"/api/v1/wallets/{context.WalletId}/accounts/{context.AccountId}/amount");
    }
}