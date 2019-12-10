using Cardano.Utils.HttpClient.Models;

namespace Cardano.Abstractions.Models.Contexts
{
    /// <summary>
    /// Query context for addresses service 
    /// </summary>
    public class AddressesContext : QueryContext
    {
        /// <summary>
        /// Wallet Identifier. Not used there
        /// </summary>
        [Query("wallet_id")]
        public override string WalletId { get; set; } = null;
        
        /// <summary>
        /// Address
        /// </summary>
        [Query("address")]
        public string Address { get; set; }
    }
}