using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Portable.Text;

namespace NureStatistic.BLL.Infrastructure
{
    public static class RequestSender
    {
        public static async Task<TResponse> Get<TResponse>(string url)
        {
            var client = new HttpClient();
            var encoding = Encoding.GetEncoding("windows-1251");

            var response = await client.GetAsync(url);
            var responseBytes = await response.Content.ReadAsByteArrayAsync();
            var responseJson = encoding.GetString(responseBytes, 0, responseBytes.Length);
            var responseJsonModel = JsonConvert.DeserializeObject<TResponse>(responseJson);

            return responseJsonModel;
        }
    }
}
