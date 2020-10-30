using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace ServantInfo.Requests
{

    public static class WebRequest
    {
        public static HttpClient client = new HttpClient();

        public static string MethodGet(string Url)
        {
            HttpRequestMessage message = new HttpRequestMessage
            {
                Method = new HttpMethod("GET"),
                RequestUri = new Uri(Url)
            };
            HttpResponseMessage response = client.SendAsync(message).Result;
            string requestResponseAsText = response.Content.ReadAsStringAsync().Result;
            return requestResponseAsText;
        }

        public static HttpResponseMessage MethodPost(string Url, string content)
        {
            HttpRequestMessage message = new HttpRequestMessage
            {
                Method = new HttpMethod("POST"),
                Content = new StringContent(content),
                RequestUri = new Uri(Url)
            };
            return client.SendAsync(message).Result;
        }
    }
}