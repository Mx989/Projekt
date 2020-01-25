using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Windows.Input;
using WpfApp.Classes;
using NewsApi;

namespace WpfApp.DataProviders
{
    public class NewsDataProvider : DataProviderBase
    {
        #region Properties
        private List<Articles> _articlesList;
        private List<string> _categories = new List<string>();
        private ObservableCollection<Articles> _articlesCollection;
        public ObservableCollection<Articles> ArticlesCollection
        {
            get { return _articlesCollection; }
            set
            {
                if(_articlesCollection != value)
                {
                    _articlesCollection = value;
                    OnPropertyChanged("ArticlesCollection");
                    
                }
            }
        }
        #endregion

        #region Constructor & Image sliding task
        public NewsDataProvider()
        {
            _categories.Add("general");
            _articlesList = newsApiLogic.getTopHeadlines("70e25f57e97c41758d9b6bb6e0ad6397", _categories);
            _articlesCollection = new ObservableCollection<Articles>();
            foreach (var element in _articlesList)
            {
                _articlesCollection.Add(element);
            }
            //Task.Run(NextImage);
        }

        public async Task NextImage()
        {
            while (true)
            { 
            ArticlesCollection.Move(0, ArticlesCollection.Count - 1);
            await Task.Delay(1000);
                OnPropertyChanged("MainNewsImage");
            }
        }
        #endregion
    }

}
