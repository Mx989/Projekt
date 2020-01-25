using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfApp.DataProviders;
using WpfApp.Classes;

namespace WpfApp.ViewModels
{
    public class NewsViewBViewModel : ViewModelBase
    {
        #region Properties
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
        #endregion

        #region Constructor
        public NewsViewBViewModel(NewsDataProvider newsDataProvider)
        {
            _newsDataProviderClient = newsDataProvider;
        }
        #endregion

        #region Commands
        private ICommand _openLinkCommand;

        public object OpenLinkCommand
        {
            get
            {
                return _openLinkCommand ?? (_openLinkCommand = new RelayCommand(
                    x =>
                    {
                        openLink();
                    }));
            }
        }

        private void openLink()
        {
            System.Diagnostics.Process.Start(Link);
        }
        #endregion
    }
}
