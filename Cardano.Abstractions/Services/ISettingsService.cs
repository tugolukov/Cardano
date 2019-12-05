using System.Threading.Tasks;
using Cardano.Abstractions.Models.Client;
using Cardano.Entities.Settings;

namespace Cardano.Abstractions.Services
{
    /// <summary>
    /// Settings service
    /// </summary>
    public interface ISettingsService
    {
        /// <summary>
        /// Retrieves the static settings for this node.
        /// </summary>
        /// <returns>Settings for node</returns>
        Task<Response<NodeSettings>> Get();
    }
}