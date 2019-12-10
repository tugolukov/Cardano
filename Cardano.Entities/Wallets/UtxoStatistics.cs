namespace Cardano.Entities.Wallets
{
    public class UtxoStatistics
    {
        public uint AllStakes { get; set; }

        public string BoundType { get; set; } = "Log10";

        public HistogramStruct Histogram { get; set; }
        
        
        public class HistogramStruct
        {
            public ulong _10 { get; set; }
            public ulong _100 { get; set; }
            public ulong _1000 { get; set; }
            public ulong _10000 { get; set; }
            public ulong _100000 { get; set; }
            public ulong _1000000 { get; set; }
            public ulong _10000000 { get; set; }
            public ulong _100000000 { get; set; }
            public ulong _1000000000 { get; set; }
            public ulong _10000000000 { get; set; }
            public ulong _100000000000 { get; set; }
            public ulong _1000000000000 { get; set; }
            public ulong _10000000000000 { get; set; }
            public ulong _100000000000000 { get; set; }
            public ulong _1000000000000000 { get; set; }
            public ulong _10000000000000000 { get; set; }
            public ulong _45000000000000000 { get; set; }
        }
    }
}