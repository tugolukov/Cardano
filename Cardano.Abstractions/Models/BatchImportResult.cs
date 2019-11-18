using System.Collections.Generic;

namespace Cardano.Abstractions.Models
{
    /// <summary>
    /// Batch Import Result
    /// </summary>
    public class BatchImportResult
    {
        /// <summary>
        /// Entities failed to be imported, if any
        /// </summary>
        public List<string> Failures { get; set; }

        /// <summary>
        /// Total number of entities successfully imported
        /// </summary>
        public int TotalSuccess { get; set; }
    }
}