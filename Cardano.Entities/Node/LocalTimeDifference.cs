using Cardano.Entities.Sync;

namespace Cardano.Entities.Node
{
    /// <summary />
    public class LocalTimeDifference : Sync<int>
    {
        /// <inheritdoc />
        public LocalTimeDifference() => Unit = "microseconds";
    }
}