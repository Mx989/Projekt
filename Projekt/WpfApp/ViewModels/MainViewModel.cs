using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfApp.Views;

namespace WpfApp.ViewModels
{
    class MainViewModel : ViewModelBase
    {
        private ICommand _goToNewsCommand;

        private object _currentNewsView;
        private object _newsViewA;
        private object _newsViewB;

        public MainViewModel()
        {
            _newsViewA = new NewsViewA();
            _newsViewB = new NewsViewB();

            CurrentNewsView = _newsViewA;
        }

        public object CurrentNewsView
        {
            get { return _currentNewsView; }
            set
            {
                _currentNewsView = value;
                OnPropertyChanged("Current View");
            }
        }

       //commands TODO

    }
}
