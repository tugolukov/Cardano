using Cardano.Entities.Sync;

namespace Cardano.Entities.Settings
{
    /// <summary>
    /// Intercept of the linear curve
    /// </summary>
    public class B : Sync<double>
    {
        /// <inheritdoc />
        public B() => Unit = "lovelace";
    }
}