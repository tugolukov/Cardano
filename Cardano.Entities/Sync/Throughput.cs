namespace Cardano.Entities.Sync
{
    /// <summary>
    /// The sync throughput, measured in blocks/s.
    /// </summary>
    public class Throughput : Sync<int>
    {
        /// <inheritdoc />
        public Throughput() => Unit = "blocksPerSecond";
    }
}