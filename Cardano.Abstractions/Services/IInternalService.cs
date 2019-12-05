using System.Threading.Tasks;
using Cardano.Abstractions.Models.Client;
using Cardano.Entities;
using Cardano.Entities.Settings;

namespace Cardano.Abstractions.Services
{
    /// <summary>
    /// Internal Service
    /// </summary>
    /// <remarks>
    /// This section contains endpoints so-called 'Internal'. They are only expected to be used by advanced users
    /// of the API (e.g. Daedalus) with which there's a privileged communication channel. Backward-compatibility
    /// or existence of these endpoints between versions is not guaranteed and won't be enforced.
    /// Use at your own risks.
    /// </remarks>
    public interface IInternalService
    {
        /// <summary>
        /// Apply the next available update
        /// </summary>
        /// <remarks>
        /// Apply the next available update proposal from the blockchain. Note that this will immediately shutdown 
        /// the node and makes it unavailable for a short while.
        /// </remarks>
        Task ApplyNextUpdate();

        /// <summary>
        /// Import a Wallet from disk.
        /// </summary>
        /// <param name="filePath">The path to the .key file holding the backup.</param>
        /// <param name="spendingPassword">An optional spending password to set for the imported wallet.</param>
        /// <returns></returns>
        Task<Response<Wallet>> ImportWallet(string filePath, string spendingPassword);

        /// <summary>
        /// Version of the next update (404 if none)
        /// </summary>
        /// <returns></returns>
        Task<Response<SoftwareInfo>> VersionOfTheNextUpdate();

        /// <summary>
        /// Discard and postpone the next available update
        /// </summary>
        /// <remarks>
        /// Discard the next available update from the node's local state. Yet, this doesn't reject the update 
        /// which will still be applied as soon as the node is restarted.
        /// </remarks>
        Task DiscardAndPostpone();

        /// <summary>
        /// Clear wallet state and all associated secret keys
        /// </summary>
        /// <remarks>
        /// Wipe-out the node's local state entirely. The only intended use-case for this endpoint 
        /// is during API integration testing. Note also that this will fail by default unless the node is running 
        /// in debug mode.
        /// </remarks>
        Task ClearWallet();
    }
}