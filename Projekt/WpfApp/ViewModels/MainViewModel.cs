using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfApp.Views;
using WpfApp.Classes;

namespace WpfApp.ViewModels
{
    class MainViewModel : ViewModelBase
    {
        #region Properties
        //News
        private ICommand _goToNewsCommand;

        private object _currentNewsView;
        private object _newsViewA;
        private object _newsViewB;

        //Weather
        private ICommand _goToWeatherCommand;

        private object _currentWeatherView;
        private object _weatherViewA;
        private object _weatherViewB;

        //Notes
        private ICommand _goToNoteCommand;

        private object _currentNotesView;
        private object _notesViewA;
        private object _notesViewB;
        #endregion

        #region Constructor
        public MainViewModel()
        {
            //Construct views for news
            _newsViewA = new NewsViewA();
            _newsViewB = new NewsViewB();

            CurrentNewsView = _newsViewA;

            //Construct views for weather
            _weatherViewA = new WeatherViewA();
            _weatherViewB = new WeatherViewB();

            CurrentWeatherView = _weatherViewA;

            //Construct views for notes
            _notesViewA = new NotesViewA();
            _notesViewB = new NotesViewB();

            CurrentNotesView = _notesViewA;
        }
        #endregion

        #region News
        public object CurrentNewsView
        {
            get { return _currentNewsView; }
            set
            {
                _currentNewsView = value;
                OnPropertyChanged("CurrentNewsView");
            }
        }

        public object GoToNewsCommand
        {
            get
            {
                return _goToNewsCommand ?? (_goToNewsCommand = new RelayCommand(
                    x =>
                    {
                        GoToNews();
                    }));
            }
        }

        public void GoToNews()
        {
            CurrentNewsView = _newsViewB;
            //TODO connecting data of specific news
        }
        #endregion

        #region Weather
        public object CurrentWeatherView
        {
            get { return _currentWeatherView; }
            set
            {
                _currentWeatherView = value;
                OnPropertyChanged("CurrentWeatherView");
            }
        }

        public object GoToWeatherCommand
        {
            get
            {
                return _goToWeatherCommand ?? (_goToWeatherCommand = new RelayCommand(
                    x =>
                    {
                        GoToWeather();
                    }));
            }
        }
        public void GoToWeather()
        {
            CurrentWeatherView = _weatherViewB;
            //TODO Connecting data of specific weather forecast
        }
        #endregion

        #region Notes
        public object CurrentNotesView
        {
            get { return _currentNotesView; }
            set
            {
                _currentNotesView = value;
                OnPropertyChanged("CurrentNotesView");
            }
        }

        public object GoToNoteCommand
        {
            get
            {
                return _goToNoteCommand ?? (_goToNoteCommand = new RelayCommand(
                    x =>
                    {
                        GoToNote();
                    }));
            }
        }

        public void GoToNote()
        {
            CurrentWeatherView = _notesViewB;
            //TODO Connecting data of specific note
        }
        #endregion
    }
}
