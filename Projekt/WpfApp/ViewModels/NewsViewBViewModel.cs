using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp.DataProviders;

namespace WpfApp.ViewModels
{
    public class NewsViewBViewModel : ViewModelBase
    {
        NewsDataProvider _newsDataProviderClient;

        public string ImgUrl
        {
            get { return _newsDataProviderClient.ArticlesCollection[0].urlToImage; }
        }

        public string Title
        {
            get { return _newsDataProviderClient.ArticlesCollection[0].title; }
        }

        public string Content
        {
            get { return _newsDataProviderClient.ArticlesCollection[0].content; }
        }

        public string Author
        {
            get { return _newsDataProviderClient.ArticlesCollection[0].author; }
        }

        public string PublishedAt
        {
            get { return _newsDataProviderClient.ArticlesCollection[0].publishedAt; }
        }

        public string Link
        {
            get { return _newsDataProviderClient.ArticlesCollection[0].url; }
        }
        public NewsViewBViewModel(NewsDataProvider newsDataProvider)
        {
            _newsDataProviderClient = newsDataProvider;
        }
    }
}
