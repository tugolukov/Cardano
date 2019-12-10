using System.Collections.Generic;
using System.Threading.Tasks;
using Cardano.Abstractions.Models;
using Cardano.Abstractions.Models.Client;
using Cardano.Abstractions.Models.Contexts;
using Cardano.Entities;

namespace Cardano.Abstractions.Services
{
    /// <summary>
    /// Account`s Service
    /// </summary>
    public interface IAccountsService
    {
        /// <summary>
        /// Retrieves the full list of Accounts.
        /// </summary>
        /// <param name="context">Context for retrieves</param>
        /// <returns>Full list of Accounts</returns>
        Task<Response<List<Account>>> GetAll(AccountsContext context);

        /// <summary>
        /// Creates a new Account for the given Wallet.
        /// </summary>
        /// <param name="walletId"></param>
        /// <param name="name">Account's name.</param>
        /// <param name="spendingPassword">Wallet's protection password, required if defined.</param>
        /// <returns>Created Account</returns>
        Task<Response<Account>> Create(string walletId, string name, string spendingPassword = "");

        /// <summary>
        /// Deletes an Account.
        /// </summary>
        /// <param name="context"></param>
        Task Delete(AccountsContext context);

        /// <summary>
        /// Retrieves a specific Account.
        /// </summary>
        /// <param name="context">Context for retrieves</param>
        /// <returns>Acccount</returns>
        Task<Response<Account>> Get(AccountsContext context);

        /// <summary>
        /// Update an Account for the given Wallet.
        /// </summary>
        /// <param name="walletId"></param>
        /// <param name="accountId"></param>
        /// <param name="name">New account's name.</param>
        /// <returns></returns>
        Task<Response<Account>> Update(string walletId, string accountId, string name);

        /// <summary>
        /// Retrieve only account's addresses.
        /// </summary>
        /// <param name="context">Context for retrieves</param>
        /// <returns></returns>
        Task<Response<List<WalletAddress>>> GetAddresses(AccountsContext context);

        /// <summary>
        /// Retrieve only account's balance.
        /// </summary>
        /// <param name="context">Context for retrieves</param>
        /// <returns></returns>
        Task<Response<ulong>> GetBalance(AccountsContext context);
    }
}