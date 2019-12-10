using System.Collections.Generic;
using Cardano.Entities.Transactions;

namespace Cardano.Abstractions.Models.Requests
{
    /// <summary>
    /// Request body for transactions service
    /// </summary>
    public class TransactionsRequest
    {
        /// <summary>
        /// One or more destinations for the payment.
        /// </summary>
        public List<PaymentDistribution> PaymentDistributions { get; set; }

        /// <summary>
        /// Optional strategy to use for selecting the transaction inputs.
        /// </summary>
        /// <remarks>
        /// Valid values: "OptimizeForSecurity", "OptimizeForHighThroughput"
        /// </remarks>
        public string GroupingPolicy { get; set; } = null;

        /// <summary>
        /// Source for the payment.
        /// </summary>
        public Source Source { get; set; }

        /// <summary>
        /// Wallet's protection password, required to spend funds if defined.
        /// </summary>
        public string SpendingPassword { get; set; }

        /// <summary />
        public TransactionsRequest()
        {
            PaymentDistributions = new List<PaymentDistribution>();
            Source = new Source();
        }
    }
}