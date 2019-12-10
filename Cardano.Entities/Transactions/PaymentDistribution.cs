namespace Cardano.Entities.Transactions
{
    /// <summary>
    /// Destination for the payment.
    /// </summary>
    public class PaymentDistribution
    {
        /// <summary>
        /// Address to map coins to.
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Amount of coin to bind, in Lovelace.
        /// </summary>
        public ulong Amount { get; set; }
    }
}