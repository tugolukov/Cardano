using System.Collections.Generic;
using Cardano.Entities.Transactions;

namespace Cardano.Entities
{
    /// <summary>
    /// Transaction model
    /// </summary>
    public class Transaction
    {
        /// <summary>
        /// Coins moved as part of the transaction, in Lovelace.
        /// </summary>
        public long Amount { get; set; }

        /// <summary>
        /// Number of confirmations.
        /// </summary>
        public ulong Confirmations { get; set; }

        /// <summary>
        /// Timestamp indicating when the transaction was created.
        /// </summary>
        public string CreationTime { get; set; }

        /// <summary>
        /// Direction for this transaction.
        /// </summary>
        /// <remarks>
        /// Valid values: "outgoing", "incoming"
        /// </remarks>
        public string Direction { get; set; }

        /// <summary>
        /// Transaction's id.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// One or more input money distributions.
        /// </summary>
        public List<PaymentDistribution> Inputs { get; set; }

        /// <summary>
        /// One or more ouputs money distributions.
        /// </summary>
        public List<PaymentDistribution> Outputs { get; set; }

        /// <summary>
        /// Shows whether or not the transaction is accepted.
        /// </summary>
        public Status Status { get; set; }

        /// <summary>
        /// Whether the transaction is entirely local or foreign.
        /// </summary>
        public string Type { get; set; }

        public Transaction()
        {
            Inputs = new List<PaymentDistribution>();
            Outputs = new List<PaymentDistribution>();
            Status = new Status();
        }
    }
}