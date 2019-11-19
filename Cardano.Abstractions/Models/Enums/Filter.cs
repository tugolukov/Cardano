using System.ComponentModel;

namespace Cardano.Abstractions.Models.Enums
{
    /// <summary>
    /// A FILTER operation on a WalletAddress. Filters support a variety of queries on the resource.
    /// </summary>
    public enum Filter
    {
        /// <summary>
        /// EQ[value] : only allow values equal to value
        /// </summary>
        [Description("EQ[value]")]
        EQ,
        
        /// <summary>
        /// LT[value] : allow resource with attribute less than the value
        /// </summary>
        [Description("LT[value]")]
        LT,
        
        /// <summary>
        /// GT[value] : allow objects with an attribute greater than the value
        /// </summary>
        [Description("GT[value]")]
        GT,
        
        /// <summary>
        /// GTE[value] : allow objects with an attribute at least the value
        /// </summary>
        [Description("GTE[value]")]
        GTE,
        
        /// <summary>
        /// LTE[value] : allow objects with an attribute at most the value
        /// </summary>
        [Description("LTE[value]")]
        LTE,
        
        /// <summary>
        /// RANGE[lo,hi] : allow objects with the attribute in the range between lo and hi
        /// </summary>
        [Description("RANGE[lo,hi]")]
        RANGE,
        
        /// <summary>
        /// IN[a,b,c,d] : allow objects with the attribute belonging to one provided.</param>
        /// </summary>
        [Description("IN[a,b,c,d]")]
        IN
    }
}