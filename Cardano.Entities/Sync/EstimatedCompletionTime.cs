using System;

namespace Cardano.Entities.Sync
{
    /// <summary>
    /// The estimated time the wallet is expected to be fully sync, based on the information available.
    /// </summary>
    public class EstimatedCompletionTime : Sync<uint>
    {
        /// <inheritdoc />
        public EstimatedCompletionTime() => Unit = "milliseconds";
    }
}