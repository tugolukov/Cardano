namespace Cardano.Entities.Sync
{
    /// <summary>
    /// The sync throughput, measured in blocks/s.
    /// </summary>
    public class Throughput : SyncAbstract
    {
        /// <inheritdoc />
        public Throughput() => Unit = "blocksPerSecond";
    }
}