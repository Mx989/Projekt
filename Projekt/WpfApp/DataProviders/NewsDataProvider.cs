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
        public NewsDataProvider()
        {
            _categories.Add("general");
            _articlesList = newsApiLogic.getTopHeadlines("70e25f57e97c41758d9b6bb6e0ad6397", _categories);
            foreach(var element in _articlesList)
            {
                if (element.urlToImage.LastIndexOf("jpg") > 0)
                    element.urlToImage = element.urlToImage.Substring(0, element.urlToImage.LastIndexOf("jpg") + 3);
                else if (element.urlToImage.LastIndexOf("jpeg") > 0)
                    element.urlToImage = element.urlToImage.Substring(0, element.urlToImage.LastIndexOf("jpeg") + 4);

                //string newUrl = element.urlToImage;
               //newUrl = newUrl.Remove(0, 5);
                //element.urlToImage = "http" + newUrl;
            }
            _articlesCollection = CreateObservableCollectionFromList(_articlesList);
            
        }


    }    

}
