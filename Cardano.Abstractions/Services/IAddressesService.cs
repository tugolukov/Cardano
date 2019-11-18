using System.Collections.Generic;
using Cardano.Abstractions.Client;
using Cardano.Entities;

namespace Cardano.Abstractions.Services
{
    /// <summary>
    /// Addresses Service
    /// </summary>
    public interface IAddressesService
    {
        /// <summary>
        /// Returns a list of the addresses.
        /// </summary>
        /// <param name="page">The page number to fetch for this request. The minimum is 1. If nothing is specified,
        /// this value defaults to 1 and always shows the first entries in the requested collection.</param>
        /// <param name="perPage">The number of entries to display for each page. The minimum is 1,
        /// whereas the maximum is 50. If nothing is specified, this value defaults to 10.</param>
        /// <returns></returns>
        Response<List<WalletAddress>> GetAll(int page = 1, int perPage = 10);

        /// <summary>
        /// Creates a new Address.
        /// </summary>
        /// <param name="accountIndex">Target account's index to store this address in.</param>
        /// <param name="walletId">Wallet's protection password, required if defined.</param>
        /// <param name="spendingPassword">Corresponding wallet identifier.</param>
        /// <returns></returns>
        Response<WalletAddress> Create(ulong accountIndex, string walletId, string spendingPassword = "");

        /// <summary>
        /// Returns interesting information about an address, if available and valid.
        /// </summary>
        /// <remarks>
        /// The previous version of this endpoint failed with an HTTP error when the given address was unknown to the wallet.
        ///
        /// This was misleading since an address that is unknown to the wallet may still belong to the wallet
        /// (since it could be part of a pending transaction in another instance of the same wallet).
        ///
        /// To reflect this, the V1 endpoint does not fail when an address is not recognised and returns
        /// a new field which indicates the address' ownership status, from the node point of view.
        /// </remarks>
        /// <param name="address"></param>
        /// <returns></returns>
        Response<WalletAddress> Get(string address);

        /// <summary>
        /// Batch import existing addresses
        /// </summary>
        /// <param name="walletId"></param>
        /// <param name="addresses">Address (string) base58</param>
        /// <returns></returns>
        Response<BatchImportResult> Import(string walletId, List<string> addresses);
    }
}