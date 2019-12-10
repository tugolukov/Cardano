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
        public override string WalletId { get; set; } = string.Empty;
        
        /// <summary>
        /// Address
        /// </summary>
        public string Address { get; set; }
    }
}