using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using NewsApi;

namespace WpfApp.ViewModels
{
    class NewsViewAViewModel
    {
        public string TheImage //TEMPORARY
        {
            get { return "https://cdn.photographylife.com/wp-content/uploads/2018/09/Nikon-Z7-Sample-Photo-960x720.jpg"; }
        }

        private ObservableCollection<Articles> _articles;

        public NewsViewAViewModel()
        {
            //_articles = newsApiLogic.querySearch();
        }


    }
}
