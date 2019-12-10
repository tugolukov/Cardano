using Cardano.Entities.Sync;

namespace Cardano.Entities.Wallets
{
    /// <summary>
    /// Wallet Model
    /// </summary>
    public class Wallet
    {
        /// <summary>
        /// The assurance level of the wallet.
        /// </summary>
        public string AssuranceLevel { get; set; }

        /// <summary>
        /// Current balance, in Lovelace.
        /// </summary>
        public ulong Balance { get; set; }

        /// <summary>
        /// The timestamp that the wallet was created.
        /// </summary>
        public string CreatedAt { get; set; }

        /// <summary>
        /// Whether or not the wallet has a passphrase.
        /// </summary>
        public bool HasSpendingPassword { get; set; }

        /// <summary>
        /// Unique wallet identifier.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Wallet's name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The timestamp that the passphrase was last updated.
        /// </summary>
        public string SpendingPasswordLastUpdate { get; set; }

        /// <summary>
        /// The sync state for this wallet.
        /// </summary>
        public SyncState SyncState { get; set; }
    }
}