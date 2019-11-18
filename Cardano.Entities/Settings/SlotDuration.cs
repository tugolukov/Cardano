using Cardano.Entities.Sync;

namespace Cardano.Entities.Settings
{
    /// <summary />
    public class SlotDuration : Sync<uint>
    {
        /// <inheritdoc />
        public SlotDuration() => Unit = "milliseconds";
    }
}