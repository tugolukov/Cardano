using System.Collections.Generic;
using Cardano.Entities.Sync;

namespace Cardano.Entities.Node
{
    /// <summary>
    /// Node Info
    /// </summary>
    public class NodeInfo
    {
        /// <summary>
        /// If known, the current blockchain height, in number of blocks.
        /// </summary>
        public BlockchainHeight BlockchainHeight { get; set; }

        /// <summary>
        /// Local blockchain height, in number of blocks.
        /// </summary>
        public BlockchainHeight LocalBlockchainHeight { get; set; }

        /// <summary>
        /// Information about the clock on this node. The field 'localTimeDifference' is only defined when the status is 'available'
        /// </summary>
        public LocalTimeInformation LocalTimeInformation { get; set; }

        /// <summary>
        /// Is the node connected to the network?
        /// </summary>
        public Dictionary<string, string> SubscriptionStatus { get; set; }

        /// <summary>
        /// Syncing progression, in percentage.
        /// </summary>
        public Percentage SyncProgress { get; set; }
    }
}