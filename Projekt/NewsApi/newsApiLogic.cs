using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace NewsApi
{
    public class newsApiLogic
    {
        //apiKey=46491296cc1342edb76a89e49524896a


        /// <summary>
        /// 
        /// </summary>
        /// <param name="token">apitoken</param>
        /// <param name="category">Lista kategorrii wybranych przez użytkownika</param>
        /// <returns>lista Articles</returns>
        public static List<Articles> getTopHeadlines(string token, List<string> category)
        {
            List<Articles> articles = new List<Articles>();
            for (var i = 0; i < category.Count; i++)
            {
                RestClient client = new RestClient("https://newsapi.org/v2/");
                RestRequest request = new RestRequest("top-headlines", Method.GET);
                request.AddParameter("apiKey", token);
                request.AddParameter("country", "us");
                request.AddParameter("pageSize", 50);
                request.AddParameter("category", category[i]);
                var _response = client.Execute(request);
                string response = _response.Content;
                var settings = new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore,
                    MissingMemberHandling = MissingMemberHandling.Ignore
                };
                Headlines headlines = JsonConvert.DeserializeObject<Headlines>(response, settings);
                List<Articles> _articles = headlines.articles;
                articles.AddRange(_articles);
            }

            articles = articles.OrderBy(a => Guid.NewGuid()).ToList();
            while (articles.Count > 50)
            {
                articles.RemoveAt(articles.Count - 1);
            }
            for (var i = 0; i < articles.Count; i++)
            {
                articles[i].content = cutEnd(articles[i].content);
            }
            return articles;

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="article">string do edycjii </param>
        /// <returns>edytowany string</returns>

        public static List<Articles> querySearch(string token, string query)
        {
            List<Articles> articles = new List<Articles>();
            RestClient client = new RestClient("https://newsapi.org/v2/");
            RestRequest request = new RestRequest("everything", Method.GET);
            request.AddParameter("apiKey", token);
            request.AddParameter("q", query);
            request.AddParameter("pageSize", 50);
            var _response = client.Execute(request);
            string response = _response.Content;
            var settings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                MissingMemberHandling = MissingMemberHandling.Ignore
            };
            Headlines headlines = JsonConvert.DeserializeObject<Headlines>(response, settings);
            List<Articles> _articles = headlines.articles;
            articles.AddRange(_articles);
            for (var i = 0; i < articles.Count; i++)
            {
                articles[i].content = cutEnd(articles[i].content);
            }
            addDescription(articles);
            return articles;
        }
        public static List<Articles> addDescription(List<Articles> articles)
        {
            for (var i = 0; i < articles.Count; i++)
            {
                if (articles[i].descrtiption is null)
                {
                    if (articles[i].content is null) articles.RemoveAt(i);
                    else articles[i].descrtiption = articles[i].content;
                }
            }
            return articles;
        }
        public static string cutEnd(string article)
        {
            try
            {
                article = article.TrimEnd(']', 'c', 'h', 'a', 'r', 's', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', '+', '[', ' ');
                return article;
            }
            catch
            {
                return article;
            }
        }
    }
}