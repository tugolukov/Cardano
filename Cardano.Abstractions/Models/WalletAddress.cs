namespace Cardano.Abstractions.Models
{
    /// <summary>
    /// Wallet Address
    /// </summary>
    public class WalletAddress
    {
        /// <summary>
        /// True if this address stores change from a previous transaction.
        /// </summary>
        public bool ChangeAddress { get; set; }

        /// <summary>
        /// Actual address.
        /// </summary>
        public string Id { get; set; }

        // TODO: Convert to enum
        /// <summary>
        /// 'isOurs' if this address is recognised as ours, 'ambiguousOwnership' if the node doesn't have information to make a unambiguous statement.
        /// </summary>
        public string Ownership { get; set; }

        /// <summary>
        /// True if this address has been used.
        /// </summary>
        public bool Used { get; set; }
    }
}