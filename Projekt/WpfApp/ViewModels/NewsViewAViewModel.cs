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
        #region Properties
        public NewsDataProvider _newsDataProviderClient;
        
        public string MainNewsImage 
        {
            get { return _newsDataProviderClient.ArticlesCollection[0].urlToImage; }
            set
            {
                _newsDataProviderClient.ArticlesCollection[0].urlToImage = value;
                OnPropertyChanged("MainNewsImage");
            }
        }

        public string SideNews1Image 
        {
            get { return _newsDataProviderClient.ArticlesCollection[1].urlToImage; }
            set
            {
                _newsDataProviderClient.ArticlesCollection[1].urlToImage = value;
                OnPropertyChanged("SideNews1Image");
            }
        }

        public string SideNews2Image
        {
            get { return _newsDataProviderClient.ArticlesCollection[2].urlToImage; }
            set
            {
                _newsDataProviderClient.ArticlesCollection[2].urlToImage = value;
                OnPropertyChanged("SideNews2Image");
            }
        }

        public string SideNews3Image 
        {
            get { return _newsDataProviderClient.ArticlesCollection[3].urlToImage; }
            set
            {
                _newsDataProviderClient.ArticlesCollection[3].urlToImage = value;
                OnPropertyChanged("SideNews3Image");
            }
        }

        public string MainNewsTitle
        {
            get { return _newsDataProviderClient.ArticlesCollection[0].title; }
            set
            {
                _newsDataProviderClient.ArticlesCollection[0].title = value;
                OnPropertyChanged("MainNewsTitle");
            }
        }

        public string SideNews1Title
        {
            get { return _newsDataProviderClient.ArticlesCollection[1].title; }
            set
            {
                _newsDataProviderClient.ArticlesCollection[1].title = value;
                OnPropertyChanged("SideNews1Title");
            }
        }

        public string SideNews2Title
        {
            get { return _newsDataProviderClient.ArticlesCollection[2].title; }
            set
            {
                _newsDataProviderClient.ArticlesCollection[2].title = value;
                OnPropertyChanged("SideNews2Title");
            }
        }

        public string SideNews3Title
        {
            get { return _newsDataProviderClient.ArticlesCollection[3].title; }
            set
            {
                _newsDataProviderClient.ArticlesCollection[3].title = value;
                OnPropertyChanged("SideNews3Title");
            }
        }
        #endregion

        #region Constructor + Switching Task
        public NewsViewAViewModel(NewsDataProvider newsDataProviderClient)
        {
            _newsDataProviderClient = newsDataProviderClient;
            Task.Run(Next);
        }
        public async Task Next()
        {
            while (true)
            {
                Switch();
                await Task.Delay(5000);
            }
        }
        #endregion

        #region News Switch Commands
        private ICommand _switch1Command;

        public object Switch1Command
        {
            get
            {
                return _switch1Command ?? (_switch1Command = new RelayCommand(
                    x =>
                    {
                        Switch();
                    }));
            }
        }

        private ICommand _switch2Command;

        public object Switch2Command
        {
            get
            {
                return _switch2Command ?? (_switch2Command = new RelayCommand(
                    x =>
                    {
                        Switch(2);
                    }));
            }
        }

        private ICommand _switch3Command;

        public object Switch3Command
        {
            get
            {
                return _switch3Command ?? (_switch3Command = new RelayCommand(
                    x =>
                    {
                        Switch(3);
                    }));
            }
        }

        public void Switch(int count = 1)
        {
            for (int i = 0; i < count; i++)
            {
                var temp = _newsDataProviderClient.ArticlesCollection[0];
                _newsDataProviderClient.ArticlesCollection.RemoveAt(0);
                _newsDataProviderClient.ArticlesCollection.Add(temp);
            }

            newsChanged();
        }

        private void newsChanged()
        {
            OnPropertyChanged("MainNewsImage");
            OnPropertyChanged("MainNewsTitle");
            OnPropertyChanged("SideNews1Image");
            OnPropertyChanged("SideNews1Title");
            OnPropertyChanged("SideNews2Image");
            OnPropertyChanged("SideNews2Title");
            OnPropertyChanged("SideNews3Image");
            OnPropertyChanged("SideNews3Title");
        }

        #endregion


    }
}
