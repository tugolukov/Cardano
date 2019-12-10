using System.Collections.Generic;

namespace Cardano.Entities.Transactions
{
    /// <summary>
    /// Request body for redeem a certificate
    /// </summary>
    public class RedeemRequest
    {
        /// <summary>
        /// Index of account
        /// </summary>
        public long AccountIndex { get; set; }

        /// <summary>
        /// An optional mnemonic. This must be provided for a paper certificate redemption.
        /// </summary>
        public List<string> Mnemonic { get; set; } = null;

        /// <summary>
        /// The redemption code associated with the Ada to redeem.
        /// </summary>
        public string RedemptionCode { get; set; }

        /// <summary>
        /// An optional spending password. This must match the password for the provided wallet ID and account index.
        /// </summary>
        public string SpendingPassword { get; set; }

        /// <summary>
        /// Wallet identifier
        /// </summary>
        public string WalletId { get; set; }
    }
}