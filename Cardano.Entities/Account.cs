using System.Collections.Generic;
using Cardano.Entities.Wallets;

namespace Cardano.Entities
{
    /// <summary>
    /// Account Model
    /// </summary>
    public class Account
    {
        /// <summary>
        /// Public addresses pointing to this account.
        /// </summary>
        public List<WalletAddress> Addresses { get; set; }

        /// <summary>
        /// Available funds, in Lovelace.
        /// </summary>
        public long Amount { get; set; }

        /// <summary>
        /// Account's index in the wallet, starting at 0.
        /// </summary>
        public long Index { get; set; }

        /// <summary>
        /// Account's name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Id of the wallet this account belongs to.
        /// </summary>
        public string WalletId { get; set; }
    }
}