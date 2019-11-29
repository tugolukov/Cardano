using Cardano.Entities.Sync;

namespace Cardano.Entities.Settings
{
    /// <summary />
    public class MaxTxSize : Sync<uint>
    {
        /// <inheritdoc />
        public MaxTxSize() => Unit = "bytes";
    }
}