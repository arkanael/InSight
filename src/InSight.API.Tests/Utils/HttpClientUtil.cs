using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace InSight.API.Tests.Utils
{
    public class HttpClientUtil
    {
        public static StringContent CreateContent(object model)
        {
            return new StringContent(JsonConvert.SerializeObject(model),
                Encoding.UTF8, "application/json");
        }

        public static string GetContent(HttpResponseMessage response)
        {
            return response.Content.ReadAsStringAsync().Result;
        }
    }
}
