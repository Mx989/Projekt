using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace WpfApp
{
    public class newsApiLogic
    {
        public static void getTopHeadlines(string token, List<string> category)
        {
            RestClient client = new RestClient("https://newsapi.org/v2/");
            RestRequest request = new RestRequest("top-headlines", Method.GET);
            request.AddParameter("apiKey", token);
            request.AddParameter("country", "pl");
            //idk works multi category
            for (int i = 0; i < category.Count; i++)
            {
                request.AddParameter("category", category[i]);
            }

            var _response = client.Execute(request);
            string response = _response.Content;
            //not end


        }
    }
}
