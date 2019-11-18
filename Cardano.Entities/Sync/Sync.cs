namespace Cardano.Entities.Sync
{
    /// <summary />
    public abstract class Sync<T>
    {
        /// <summary />
        public T Quantity { get; set; }
        
        /// <summary />
        public string Unit { get; set; }
    }
}