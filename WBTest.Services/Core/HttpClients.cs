using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace WBTest.Services.Core
{
    public static class HttpClients
    {
        static HttpClient client = new HttpClient();


       
        public static HttpClient GetHttpClient()
        {
            client.BaseAddress = new Uri("https://wema-alatdev-apimgt.azure-api.net/alat-test/api/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            return client;
        }
    }
}
