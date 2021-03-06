﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.ComponentModel;
using NewsApi;

namespace WpfApp.DataProviders
{
    public class DataProviderBase : INotifyPropertyChanged
    {
        // INotifyPropertyChanged support

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
            {
            var handler = PropertyChanged;
            if (handler != null) 
                {
                    handler(this, new PropertyChangedEventArgs(propertyName));
                }
            }   
    }
}
