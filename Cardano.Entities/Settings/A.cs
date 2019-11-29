using Cardano.Entities.Sync;

namespace Cardano.Entities.Settings
{
    /// <summary>
    /// Slope of the linear curve
    /// </summary>
    public class A : Sync<double>
    {
        /// <inheritdoc />
        public A() => Unit = "lovelace/byte";
    }
}