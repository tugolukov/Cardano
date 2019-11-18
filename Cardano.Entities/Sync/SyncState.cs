namespace Cardano.Entities.Sync
{
    /// <summary>
    /// The sync state for wallet.
    /// </summary>
    public class SyncState
    {
        /// <summary>
        /// 
        /// </summary>
        public SyncProgress SyncProgress { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Tag { get; set; }
    }
}