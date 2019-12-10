using Cardano.Utils.HttpClient.Models;

namespace Cardano.Abstractions.Models.Contexts
{
    /// <summary>
    /// Query context for accounts service 
    /// </summary>
    public class AccountsContext : QueryContext
    {
        /// <summary>
        /// Account Identifier
        /// </summary>
        [Query("account_id")]
        public string AccountId { get; set; } = null;
    }
}