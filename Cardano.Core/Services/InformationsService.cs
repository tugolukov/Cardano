using System;
using System.Net.Http;
using System.Threading.Tasks;
using Cardano.Abstractions.Models;
using Cardano.Abstractions.Models.Client;
using Cardano.Abstractions.Services;
using Cardano.Entities.Node;
using Cardano.Utils.HttpClient.Extensions;

namespace Cardano.Core.Services
{
    /// <inheritdoc />
    public class InformationsService : IInformationsService
    {
        private readonly HttpClient _client;

        /// <inheritdoc />
        public InformationsService(ConnectionOptions options)
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri(options.Url);
        }

        /// <inheritdoc />
        public async Task<Response<NodeInfo>> Get(bool forceNtpCheck = false) =>
            await _client.GetAsync<Response<NodeInfo>>($"api/v1/node-info?force_ntp_check={forceNtpCheck}");
    }
}