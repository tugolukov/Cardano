using System.Net.Http;
using System.Text;
using Newtonsoft.Json;

namespace Cardano.Core.Utils
{
    /// <summary>
    /// Методы расширения для <see cref="JsonContent"/>
    /// </summary>
    public class JsonContent : StringContent
    {
        /// <summary/>
        public JsonContent(object obj, NullValueHandling nullHandling = NullValueHandling.Ignore,
            ReferenceLoopHandling loopHandling = ReferenceLoopHandling.Ignore) :
            base(JsonConvert.SerializeObject(obj, new JsonSerializerSettings
            {
                NullValueHandling = nullHandling,
                ReferenceLoopHandling = loopHandling
            }), Encoding.UTF8, "application/json")
        {
        }
    }
}