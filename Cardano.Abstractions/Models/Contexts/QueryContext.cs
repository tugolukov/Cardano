using Cardano.Utils.HttpClient.Models;

namespace Cardano.Abstractions.Models.Contexts
{
    public abstract class QueryContext
    {
        /// <summary>
        /// Wallet Identifier
        /// </summary>
        [Query("wallet_id")]
        public virtual string WalletId { get; set; }
        
        /// <summary>
        /// The page number to fetch for this request. The minimum is 1. If nothing is specified,
        /// this value defaults to 1 and always shows the first entries in the requested collection.
        /// </summary>
        [Query("page")]
        public int Page { get; set; } = 1;

        /// <summary>
        /// The number of entries to display for each page. The minimum is 1,
        /// whereas the maximum is 50. If nothing is specified, this value defaults to 10.
        /// </summary>
        [Query("per_page")]
        public int PerPage { get; set; } = 10;
    }
}