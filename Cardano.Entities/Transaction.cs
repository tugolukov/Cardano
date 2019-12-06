namespace Cardano.Entities
{
    public class Transaction
    {
        public long Amount { get; set; }
        public ulong Confirmations { get; set; }
        public string CreationTime { get; set; }
        public string Direction { get; set; }
        public string Id { get; set; }
        
    }

    public class PaymentDistribution
    {
        public string Address { get; set; }
        public ulong Amount { get; set; }
    }
}