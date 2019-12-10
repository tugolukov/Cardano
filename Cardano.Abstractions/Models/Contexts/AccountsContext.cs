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
        public string AccountId { get; set; } = "";
    }
}