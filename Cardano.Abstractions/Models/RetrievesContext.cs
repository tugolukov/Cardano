namespace Cardano.Abstractions.Models
{
    /// <summary>
    /// Context for retrieves
    /// </summary>
    public class RetrievesContext
    {
        /// <summary>
        /// Wallet Identifier
        /// </summary>
        public string WalletId { get; set; }

        /// <summary>
        /// Account Identifier
        /// </summary>
        public string AccountId { get; set; } = "";

        /// <summary>
        /// The page number to fetch for this request. The minimum is 1. If nothing is specified,
        /// this value defaults to 1 and always shows the first entries in the requested collection.
        /// </summary>
        public int Page { get; set; } = 1;

        /// <summary>
        /// The number of entries to display for each page. The minimum is 1,
        /// whereas the maximum is 50. If nothing is specified, this value defaults to 10.
        /// </summary>
        public int PerPage { get; set; } = 10;

        /// <summary>
        /// A FILTER operation on a WalletAddress. Filters support a variety of queries on the resource. These are:
        /// EQ[value] : only allow values equal to value
        /// LT[value] : allow resource with attribute less than the value
        /// GT[value] : allow objects with an attribute greater than the value
        /// GTE[value] : allow objects with an attribute at least the value
        /// LTE[value] : allow objects with an attribute at most the value
        /// RANGE[lo,hi] : allow objects with the attribute in the range between lo and hi
        /// IN[a,b,c,d] : allow objects with the attribute belonging to one provided.
        /// </summary>
        public string Filter { get; set; } = "";
    }
}