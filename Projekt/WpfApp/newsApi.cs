using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp
{
    class Headlines
    {
        public string status { get; set; }
        public int totalResults { get; set; }
        public Articles articles { get; set; }
    }
    class Articles
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
    class Source
    {
        public string id { get; set; }
        public string name { get; set; }
    }
    class _Sources
    {
        public string status { get; set; }
        public Sources sources { get; set; }

    }
    class Sources
    {
        public string id {get; set;}
        public string name {get; set;}
        public string description {get; set;}
        public string url {get; set;}
        public string category {get; set;}
        public string language {get; set;}
        public string country {get; set;}
    }
}
