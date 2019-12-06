namespace Cardano.Abstractions.Models
{
    public class TransactionsContext
    {
        public string WalletId { get; set; }
        public ulong AccountIndex { get; set; }
        public string Address { get; set; }
        public uint Page { get; set; }
        public ushort PerPage { get; set; }
        
    }
}