namespace Cardano.Entities.Settings
{
    /// <summary>
    /// The fee policy.
    /// </summary>
    public class FeePolicy
    {
        /// <summary>
        /// Slope of the linear curve
        /// </summary>
        public A A { get; set; }
        
        /// <summary>
        /// Intercept of the linear curve
        /// </summary>
        public B B { get; set; }
    }
}