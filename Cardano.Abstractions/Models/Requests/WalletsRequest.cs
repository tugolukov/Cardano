using System.Collections.Generic;

namespace Cardano.Abstractions.Models.Requests
{
    /// <summary>
    /// Request body for create wallet
    /// </summary>
    public class WalletsRequest
    {
        /// <summary>
        /// Desired assurance level based on the number of confirmations counter of each transaction.
        /// </summary>
        /// <remarks>
        /// Valid values: "normal", "strict"
        /// </remarks>
        public string AssuranceLevel { get; set; }

        /// <summary>
        /// Backup phrase to restore the wallet.
        /// </summary>
        public List<string> BackupPhrase { get; set; }

        /// <summary>
        /// Wallet's name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Create a new wallet or Restore an existing one.
        /// </summary>
        /// <remarks>
        /// Valid values: "create", "restore"
        /// </remarks>
        public string Operation { get; set; }

        /// <summary>
        /// Optional (but recommended) password to protect the wallet on sensitive operations.
        /// </summary>
        public string SpendingPassword { get; set; } = "";
    }
}