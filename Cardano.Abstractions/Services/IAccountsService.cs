using System.Collections.Generic;
using Cardano.Abstractions.Models;
using Cardano.Abstractions.Models.Client;
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
        Response<List<Account>> GetAll(RetrievesContext context);

        /// <summary>
        /// Creates a new Account for the given Wallet.
        /// </summary>
        /// <param name="walletId"></param>
        /// <param name="name">Account's name.</param>
        /// <param name="spendingPassword">Wallet's protection password, required if defined.</param>
        /// <returns>Created Account</returns>
        Response<Account> Create(string walletId, string name, string spendingPassword = "");

        /// <summary>
        /// Deletes an Account.
        /// </summary>
        /// <param name="walletId"></param>
        /// <param name="accountId"></param>
        void Delete(string walletId, string accountId);

        /// <summary>
        /// Retrieves a specific Account.
        /// </summary>
        /// <param name="context">Context for retrieves</param>
        /// <returns>Acccount</returns>
        Response<Account> Get(RetrievesContext context);
        
        /// <summary>
        /// Update an Account for the given Wallet.
        /// </summary>
        /// <param name="walletId"></param>
        /// <param name="accountId"></param>
        /// <param name="name">New account's name.</param>
        /// <returns></returns>
        Response<Account> Update(string walletId, string accountId, string name);

        /// <summary>
        /// Retrieve only account's addresses.
        /// </summary>
        /// <param name="context">Context for retrieves</param>
        /// <returns></returns>
        Response<List<WalletAddress>> GetAddresses(RetrievesContext context);

        /// <summary>
        /// Retrieve only account's balance.
        /// </summary>
        /// <param name="context">Context for retrieves</param>
        /// <returns></returns>
        Response<ulong> GetBalance(RetrievesContext context);
    }
}