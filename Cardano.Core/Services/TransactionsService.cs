using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Cardano.Abstractions.Models;
using Cardano.Abstractions.Models.Client;
using Cardano.Abstractions.Models.Contexts;
using Cardano.Abstractions.Models.Requests;
using Cardano.Abstractions.Services;
using Cardano.Entities;
using Cardano.Utils.HttpClient.Extensions;

namespace Cardano.Core.Services
{
    /// <inheritdoc />
    public class TransactionsService : ITransactionsService
    {
        private readonly HttpClient _client;

        /// <inheritdoc />
        public TransactionsService(ConnectionOptions options)
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri(options.Url);
        }

        /// <inheritdoc />
        public async Task<Response<List<Transaction>>> RetrievesHistory(TransactionsContext context) =>
            await _client.GetAsync<Response<List<Transaction>>>(
                "/api/v1/transactions" +
                $"?wallet_id={context.WalletId}" +
                $"?account_index={context.AccountIndex}" +
                $"?address={context.Address}" +
                $"?page={context.Page}" +
                $"?per_page={context.PerPage}");

        /// <inheritdoc />
        public async Task<Response<Transaction>> GeneratesTransaction(TransactionsRequest body) =>
            await _client.PostAsync<Response<Transaction>>("api/v1/transactions", body);

        /// <inheritdoc />
        public async Task<Response<Transaction>> RedeemCertificate(RedeemRequest body) =>
            await _client.PostAsync<Response<Transaction>>("/api/v1/transactions/certificates", body);

        /// <inheritdoc />
        public async Task<Response<long>> Estimate(TransactionsRequest body) =>
            await _client.PostAsync<Response<long>>("/api/v1/transactions/fees", body);
    }
}