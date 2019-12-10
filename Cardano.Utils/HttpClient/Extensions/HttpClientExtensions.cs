using System.Net.Http;
using System.Threading.Tasks;
using Cardano.Core.Utils;
using Newtonsoft.Json;

namespace Cardano.Utils.HttpClient.Extensions
{
    /// <summary>
    /// Методы расширения для HttpClient
    /// </summary>
    public static class HttpClientExtensions
    {
        /// <summary>
        /// GET-запрос
        /// </summary>
        /// <param name="client">HttpCLient</param>
        /// <param name="requestUri">Адрес назначения</param>
        /// <typeparam name="T">Тип возвращаемого значения</typeparam>
        /// <returns></returns>
        public static async Task<T> GetAsync<T>(this System.Net.Http.HttpClient client, string requestUri)
        {
            using (client)
            {
                var response = await client.GetAsync(requestUri);
                return await response.Content.ReadAsAsync<T>();
            }
        }

        /// <summary>
        /// POST-запрос
        /// </summary>
        /// <param name="client">HttpCLient</param>
        /// <param name="requestUri">Адрес назначения</param>
        /// <param name="body">Передаваемый объект</param>
        /// <typeparam name="T">Тип возвращаемого значения</typeparam>
        /// <returns></returns>
        public static async Task<T> PostAsync<T>(this System.Net.Http.HttpClient client, string requestUri, object body)
        {
            using (client)
            {
                var jsonContent = new JsonContent(body);

                var response = await client.PostAsync(requestUri, jsonContent);
                return await response.Content.ReadAsAsync<T>();
            }
        }
        
        /// <summary>
        /// PUT-запрос
        /// </summary>
        /// <param name="client">HttpCLient</param>
        /// <param name="requestUri">Адрес назначения</param>
        /// <param name="body">Передаваемый объект</param>
        /// <typeparam name="T">Тип возвращаемого значения</typeparam>
        /// <returns></returns>
        public static async Task<T> PutAsync<T>(this System.Net.Http.HttpClient client, string requestUri, object body)
        {
            var jsonContent = new JsonContent(body);

            var response = await client.PutAsync(requestUri, jsonContent);
            return await response.Content.ReadAsAsync<T>();
        }
        
        /// <summary>
        /// DELETE-запрос
        /// </summary>
        /// <param name="client">HttpCLient</param>
        /// <param name="requestUri">Адрес назначения</param>
        /// <returns></returns>
        public static async Task DeleteVoidAsync(this System.Net.Http.HttpClient client, string requestUri)
        {
            using (client)
            {
                await client.DeleteAsync(requestUri);
            }
        }
        
        /// <summary>
        /// Десериализация JSON Content в объект
        /// </summary>
        /// <typeparam name="T"> Тип конечного объекта </typeparam>
        /// <param name="content"> <see cref="HttpContent"/> </param>
        /// <returns> <see cref="Task"/> </returns>
        public static async Task<T> ReadAsAsync<T> (this HttpContent content)
        {
            var str = await content.ReadAsStringAsync ();
            return JsonConvert.DeserializeObject<T> (str);
        }
    }
}