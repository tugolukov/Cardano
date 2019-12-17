using System;

namespace Cardano.Utils.HttpClient.Models
{
    /// <summary>
    /// Attribute for auery parameters
    /// </summary>
    public class QueryAttribute : Attribute
    {
        /// <summary>
        /// Name of attribute
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Base constructor
        /// </summary>
        /// <param name="name">Value for name of attribute</param>
        public QueryAttribute(string name)
        {
            Name = name;
        }
    }
}