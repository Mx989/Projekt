﻿using System;
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
            get { return "http://images.pexels.com/photos/744667/pexels-photo-744667.jpeg"; }
        }

        private ObservableCollection<Articles> _articles;

        public NewsViewAViewModel()
        {
            //_articles = newsApiLogic.querySearch();
        }


    }
}
