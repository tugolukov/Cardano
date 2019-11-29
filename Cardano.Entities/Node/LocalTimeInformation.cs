namespace Cardano.Entities.Node
{
    /// <summary>
    /// Information about the clock on this node. The field 'localTimeDifference' is only defined when the status is 'available'
    /// </summary>
    public class LocalTimeInformation
    {
        /// <summary />
        public LocalTimeDifference LocalTimeDifference { get; set; }

        /// <summary>
        /// Valid values: "unavailable", "pending", "available"
        /// </summary>
        public string Status { get; set; }
    }
}