using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Collections.ObjectModel;
using WpfApp.Views;
using WpfApp.Classes;
using WpfApp.DataProviders;
using NewsApi;

namespace WpfApp.ViewModels
{
    class MainViewModel : ViewModelBase
    {

        #region Properties
        public string HomeIcon
        {
            get { return "https://image.shutterstock.com/image-vector/home-icon-sign-symbol-260nw-1229123275.jpg"; }
        }
        private ICommand _goToHomePageCommand;

        //News
        private ICommand _goToNewsCommand;

        private object _currentNewsView;
        private object _newsViewA;
        private object _newsViewB;

        //Weather
        private ICommand _goToWeatherCommand;
        private ICommand _goToCalendarCommand;

        private object _currentWeatherView;
        private object _weatherViewA;
        private object _weatherViewB;
        private object _calendarView;

        //Notes

        private object _currentNotesView;
        private object _notesViewA;

        //Data Providers

        public NewsDataProvider NewsDataProviderClient = new NewsDataProvider();
        public WeatherDataProvider WeatherDataProviderClient = new WeatherDataProvider();
        public NotesDataProvider NotesDataProviderClient = new NotesDataProvider();
        #endregion

        #region Constructor
        public MainViewModel()
        {
            //Construct views for news
            var _newsVMA = new NewsViewAViewModel(NewsDataProviderClient);
            _newsViewA = new NewsViewA(_newsVMA);

            CurrentNewsView = _newsViewA;

            //Construct views for weather
            var _weatherVMA = new WeatherViewAViewModel(WeatherDataProviderClient);
            _weatherViewA = new WeatherViewA(_weatherVMA);

            var _weatherVMB = new WeatherViewBViewModel(WeatherDataProviderClient);
            _weatherViewB = new WeatherViewB(_weatherVMB);
            
            _calendarView = new CalendarView();

            CurrentWeatherView = _weatherViewA;

            //Construct views for notes
            var _notesVMA = new NotesViewAViewModel(NotesDataProviderClient);
            _notesViewA = new NotesViewA(_notesVMA);

            CurrentNotesView = _notesViewA;
        }

        #endregion

        #region Navigation
        public object GoToHomePageCommand
        {
            get
            {
                return _goToHomePageCommand ?? (_goToHomePageCommand = new RelayCommand(
                    x =>
                    {
                        GoToHomePage();
                    }));
            }
        }

        public void GoToHomePage()
        {
            CurrentNewsView = _newsViewA;
            CurrentWeatherView = _weatherViewA;
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
            var _newsVMB = new NewsViewBViewModel(NewsDataProviderClient);
            _newsViewB = new NewsViewB(_newsVMB);

            CurrentNewsView = _newsViewB;
            
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

        #region Calendar

        public object GoToCalendarCommand
        {
            get
            {
                return _goToCalendarCommand ?? (_goToCalendarCommand = new RelayCommand(
                    x =>
                    {
                        GoToCalendar();
                    }));
            }
        }
        public void GoToCalendar()
        {
            CurrentWeatherView = _calendarView;
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
        #endregion
    }
}
