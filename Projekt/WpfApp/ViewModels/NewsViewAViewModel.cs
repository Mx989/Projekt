using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Windows.Input;
using NewsApi;
using WpfApp.Classes;
using WpfApp.DataProviders;

namespace WpfApp.ViewModels
{
    public class NewsViewAViewModel : ViewModelBase
    {
        private NewsDataProvider _newsDataProviderClient;

        private ICommand _moveCommand;

        private string _mainNewsTitle = "Example main news title";
        private string _sideNews1Title = "Example side news 1 title";
        private string _sideNews2Title = "Example side news 2 title";
        private string _sideNews3Title = "Example side news 3 title";
        private int _movement = 0;

        public int Movement
        {
            get { return _movement; }
            set
            {
                if (_movement != value)
                {
                    _movement = value;
                    OnPropertyChanged("Movement");
                }
            }
        }

        public string MainNewsImage 
        {
            get { return _newsDataProviderClient.ArticlesCollection[0 + Movement].urlToImage; }
        }

        public string SideNews1Image 
        {
            get { return _newsDataProviderClient.ArticlesCollection[1].urlToImage; }
        }

        public string SideNews2Image
        {
            get { return _newsDataProviderClient.ArticlesCollection[2].urlToImage; }
        }

        public string SideNews3Image 
        {
            get { return _newsDataProviderClient.ArticlesCollection[3].urlToImage; }
        }

        public string MainNewsTitle
        {
            get { return _newsDataProviderClient.ArticlesCollection[0].title; }
            set
            {
                _mainNewsTitle = value;
                OnPropertyChanged("MainNewsTitle");
            }
        }

        public string SideNews1Title
        {
            get { return _newsDataProviderClient.ArticlesCollection[1].title; }
            set
            {
                _sideNews1Title = value;
                OnPropertyChanged("SideNews1Title");
            }
        }

        public string SideNews2Title
        {
            get { return _newsDataProviderClient.ArticlesCollection[2].title; }
            set
            {
                _sideNews2Title = value;
                OnPropertyChanged("SideNews2Title");
            }
        }

        public string SideNews3Title
        {
            get { return _newsDataProviderClient.ArticlesCollection[3].title; }
            set
            {
                _sideNews3Title = value;
                OnPropertyChanged("SideNews3Title");
            }
        }

        public NewsViewAViewModel(NewsDataProvider newsDataProviderClient)
        {
            _newsDataProviderClient = newsDataProviderClient;
           // StartMovingNews();

        }

    }
}
