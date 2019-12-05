using System.Threading.Tasks;
using Cardano.Abstractions.Models.Client;
using Cardano.Entities.Node;

namespace Cardano.Abstractions.Services
{
    /// <summary>
    /// Info Service
    /// </summary>
    public interface IInformationsService
    {
        /// <summary>
        /// Retrieves the dynamic information for this node.
        /// </summary>
        /// <param name="forceNtpCheck">In some cases, API Clients need to force
        ///     a new NTP check as a previous result gets cached. A typical use-case is after asking
        ///     a user to fix its system clock. If this flag is set, request will block until NTP server
        ///     responds or it will timout if NTP server is not available within 30 seconds.</param>
        /// <returns>Node Information</returns>
        Task<Response<NodeInfo>> Get(bool forceNtpCheck = false);
    }
}