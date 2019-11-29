namespace Cardano.Entities.Sync
{
    /// <summary>
    /// Sync Progress Model
    /// </summary>
    public class SyncProgress
    {
        /// <summary>
        /// The estimated time the wallet is expected to be fully sync, based on the information available.
        /// </summary>
        public EstimatedCompletionTime EstimatedCompletionTime { get; set; }
        /// <summary>
        /// The sync percentage, from 0% to 100%.
        /// </summary>
        public Percentage Percentage { get; set; }
        /// <summary>
        /// The sync throughput, measured in blocks/s.
        /// </summary>
        public Throughput Throughput{ get; set; }
    }
}