using System;
using System.Net.Http;
using System.Threading.Tasks;
using Cardano.Abstractions.Models;
using Cardano.Abstractions.Models.Client;
using Cardano.Abstractions.Services;
using Cardano.Core.Extensions;
using Cardano.Entities.Settings;

namespace Cardano.Core.Services
{
    /// <inheritdoc />
    public class SettingsService : ISettingsService
    {
        private readonly HttpClient _client;

        /// <inheritdoc />
        public SettingsService(ConnectionOptions options)
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri(options.Url);
        }

        /// <inheritdoc />
        public async Task<Response<NodeSettings>> Get()
        {
            return await _client.GetAsync<Response<NodeSettings>>($"/api/v1/node-settings");
        }
    }
}