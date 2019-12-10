using System.Collections.Generic;
using System.Threading.Tasks;
using Cardano.Abstractions.Models.Client;
using Cardano.Abstractions.Models.Contexts;
using Cardano.Abstractions.Models.Requests;
using Cardano.Entities.Wallets;

namespace Cardano.Abstractions.Services
{
    /// <summary>
    /// Wallet service
    /// </summary>
    public interface IWalletsService
    {
        /// <summary>
        /// Returns a list of the available wallets.
        /// </summary>
        /// <param name="context">Query parameters</param>
        /// <returns></returns>
        Task<Response<List<Wallet>>> GetAll(WalletsContext context);
        
        /// <summary>
        /// Creates a new or restores an existing Wallet.
        /// </summary>
        /// <param name="body"></param>
        /// <returns></returns>
        Task<Response<Wallet>> Create(WalletsRequest body);

        /// <summary>
        /// Deletes the given Wallet and all its accounts.
        /// </summary>
        /// <returns></returns>
        Task Delete(string walletId);

        /// <summary>
        /// Returns the Wallet identified by the given walletId.
        /// </summary>
        /// <param name="walletId"></param>
        /// <returns></returns>
        Task<Response<Wallet>> Get(string walletId);

        /// <summary>
        /// Update the Wallet identified by the given walletId.
        /// </summary>
        /// <param name="walletId"></param>
        /// <param name="assuranceLevel">New assurance level.</param>
        /// <param name="name">New wallet's name.</param>
        /// <returns></returns>
        Task<Response<Wallet>> Update(string walletId, string assuranceLevel, string name);

        /// <summary>
        /// Updates the password for the given Wallet.
        /// </summary>
        /// <param name="walletId"></param>
        /// <param name="oldPassword">Old password.</param>
        /// <param name="newPassword">New password.</param>
        /// <returns></returns>
        Task<Response<Wallet>> UpdatePassword(string walletId, string oldPassword, string newPassword);
        
        /// <summary>
        /// Returns Utxo statistics for the Wallet identified by the given walletId.
        /// </summary>
        /// <param name="walletId"></param>
        /// <returns></returns>
        Task<Response<UtxoStatistics>> GetUtxo(string walletId);
    }
}