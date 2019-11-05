using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;

namespace POPS
{
    public class POPSClient
    {
        public static HttpClient webApiClient = new HttpClient();

        static POPSClient()
        {
            webApiClient.BaseAddress = new Uri("http://localhost:8084/api/");
            webApiClient.DefaultRequestHeaders.Clear();
            webApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

    }
}