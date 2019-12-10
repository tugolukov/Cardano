using Cardano.Utils.HttpClient.Models;

namespace Cardano.Abstractions.Models.Contexts
{
    /// <summary>
    /// Query context for transactions service 
    /// </summary>
    public class TransactionsContext : QueryContext
    {
        /// <summary>
        /// Account Index
        /// </summary>
        [Query("account_index")]
        public ulong AccountIndex { get; set; }

        /// <summary>
        /// Address
        /// </summary>
        [Query("address")]
        public string Address { get; set; }

        /// <summary>
        /// A SORT operation on this Transaction. Allowed keys: created_at.
        /// </summary>
        [Query("sort_by")]
        public string SortBy { get; set; } = "created_at";
    }
}