using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using NewsApi;

namespace WpfApp.ViewModels
{
    class NewsViewAViewModel : ViewModelBase
    {
        private string _mainNewsTitle = "Example main news title";
        private string _sideNews1Title = "Example side news 1 title";
        private string _sideNews2Title = "Example side news 2 title";
        private string _sideNews3Title = "Example side news 3 title";
        public string MainNewsImage //TEMPORARY
        {
            get { return "https://cdn.photographylife.com/wp-content/uploads/2018/09/Nikon-Z7-Sample-Photo-960x720.jpg"; }
        }

        public string SideNews1Image //TEMPORARY
        {
            get { return "https://cdn.photographylife.com/wp-content/uploads/2018/09/Nikon-Z7-Sample-Photo-960x720.jpg"; }
        }

        public string SideNews2Image //TEMPORARY
        {
            get { return "https://cdn.photographylife.com/wp-content/uploads/2018/09/Nikon-Z7-Sample-Photo-960x720.jpg"; }
        }

        public string SideNews3Image //TEMPORARY
        {
            get { return "https://cdn.photographylife.com/wp-content/uploads/2018/09/Nikon-Z7-Sample-Photo-960x720.jpg"; }
        }

        public string MainNewsTitle
        {
            get { return _mainNewsTitle; }
            set
            {
                _mainNewsTitle = value;
                OnPropertyChanged("MainNewsTitle");
            }
        }

        public string SideNews1Title
        {
            get { return _sideNews1Title; }
            set
            {
                _sideNews1Title = value;
                OnPropertyChanged("SideNews1Title");
            }
        }

        public string SideNews2Title
        {
            get { return _sideNews2Title; }
            set
            {
                _sideNews2Title = value;
                OnPropertyChanged("SideNews2Title");
            }
        }

        public string SideNews3Title
        {
            get { return _sideNews3Title; }
            set
            {
                _sideNews3Title = value;
                OnPropertyChanged("SideNews3Title");
            }
        }

        private ObservableCollection<Articles> _articles;

        public NewsViewAViewModel()
        {
            //_articles = newsApiLogic.querySearch();
        }


    }
}
