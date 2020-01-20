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
        public NewsViewBViewModel(NewsDataProvider newsDataProvider)
        {
            _newsDataProviderClient = newsDataProvider;
        }
    }
}
