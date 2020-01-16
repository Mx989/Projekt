using System;
using System.Collections.Generic;
using System.Text;

namespace NewsApi
{
    public class Headlines
    {
        public string status { get; set; }
        public int totalResults { get; set; }
        public List<Articles> articles { get; set; }
    }
    public class Articles
    {
        public Source source { get; set; }
        public string author { get; set; }
        public string title { get; set; }
        public string descrtiption { get; set; }
        public string url { get; set; }
        public string urlToImage { get; set; }
        public string publishedAt { get; set; }
        public string content { get; set; }
    }
    public class Source
    {
        public string id { get; set; }
        public string name { get; set; }
    }
    public class _Sources
    {
        public string status { get; set; }
        public Sources sources { get; set; }

    }
    public class Sources
    {
        public string id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string url { get; set; }
        public string category { get; set; }
        public string language { get; set; }
        public string country { get; set; }
    }
}
