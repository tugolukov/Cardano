namespace Cardano.Entities.Settings
{
    /// <summary>
    /// Settings of node
    /// </summary>
    public class NodeSettings
    {
        /// <summary>
        /// The fee policy.
        /// </summary>
        public FeePolicy FeePolicy { get; set; }

        /// <summary>
        /// Git revision of this deployment.
        /// </summary>
        public string GitRevision { get; set; }

        /// <summary>
        /// The largest allowed transaction size
        /// </summary>
        public MaxTxSize MaxTxSize { get; set; }

        /// <summary>
        /// Current project's version.
        /// </summary>
        public string ProjectVersion { get; set; }

        /// <summary>
        /// The security parameter.
        /// </summary>
        public uint SecurityParameter { get; set; }
        
        /// <summary>
        /// The number of slots per epoch.
        /// </summary>
        public uint SlotCount { get; set; }

        /// <summary>
        /// Duration of a slot.
        /// </summary>
        public SlotDuration SlotDuration { get; set; }

        /// <summary>
        /// The current slot and epoch.
        /// </summary>
        public SlotId SlotId { get; set; }

        /// <summary>
        /// Various pieces of information about the current software.
        /// </summary>
        public SoftwareInfo SoftwareInfo { get; set; }
    }
}