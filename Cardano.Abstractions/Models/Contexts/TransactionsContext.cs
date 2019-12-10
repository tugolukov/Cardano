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
        public ulong AccountIndex { get; set; }

        /// <summary>
        /// Address
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// A SORT operation on this Transaction. Allowed keys: created_at.
        /// </summary>
        public string SortBy { get; set; } = "created_at";
    }
}