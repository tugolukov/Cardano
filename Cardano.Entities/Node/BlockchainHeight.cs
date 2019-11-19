using Cardano.Entities.Sync;

namespace Cardano.Entities.Node
{
    /// <summary>
    /// Blockchain height, in number of blocks.
    /// </summary>
    public class BlockchainHeight : Sync<uint>
    {
        /// <inheritdoc />
        public BlockchainHeight() => Unit = "blocks";
    }
}