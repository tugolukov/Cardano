namespace Cardano.Entities.Transactions
{
    /// <summary>
    /// Source for the payment.
    /// </summary>
    public class Source
    {
        /// <summary>
        /// Corresponding account's index on the wallet.
        /// </summary>
        public ulong AccountIndex { get; set; }

        /// <summary>
        /// Target wallet identifier to reach.
        /// </summary>
        public string WalletId { get; set; }
    }
}