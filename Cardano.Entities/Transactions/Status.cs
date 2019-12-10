namespace Cardano.Entities.Transactions
{
    /// <summary>
    /// Shows whether or not the transaction is accepted.
    /// </summary>
    public class Status
    {
        /// <summary>
        /// Info
        /// </summary>
        public object Data { get; set; }

        /// <summary>
        /// Valid values: "applying", "inNewestBlocks", "persisted", "wontApply", "creating"
        /// </summary>
        public string Tag { get; set; }
    }
}