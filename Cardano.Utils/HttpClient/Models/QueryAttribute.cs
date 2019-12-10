using System;

namespace Cardano.Utils.HttpClient.Models
{
    public class QueryAttribute : Attribute
    {
        public string Name { get; set; }

        public QueryAttribute(string name)
        {
            Name = name;
        }
    }
}