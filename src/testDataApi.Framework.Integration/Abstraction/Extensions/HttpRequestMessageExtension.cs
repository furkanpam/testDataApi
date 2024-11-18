using System.Net.Http.Headers;

namespace Asis.Framework.Integration.Abstraction.Extensions
{
    public static class HttpRequestMessageExtension
    {
        public static HttpRequestMessage AddHeadersRange(this HttpRequestMessage message, HttpRequestHeaders keyValuePairs)
        {
            foreach (var (key, value) in keyValuePairs)
            {
                message.Headers.Add(key, value);
            }

            return message;
        }

        public static HttpRequestMessage AddPropertiesRange(this HttpRequestMessage message, IDictionary<string, object> keyValuePairs)
        {
            foreach (var (key, value) in keyValuePairs)
            {
                message.Properties.Add(key, value);
            }

            return message;
        }
    }
}
