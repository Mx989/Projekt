using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Windows.Input;
using WpfApp.DataProviders;
using WpfApp.Classes;
using DailyNotesClasses;

namespace WpfApp.ViewModels
{
    public class NotesViewAViewModel: ViewModelBase
    {
        //public NotesDataProvider NotesDataProviderClient;
        private ObservableCollection<string> _notesList = new ObservableCollection<string>();
        DailyNotes dailyNotes = new DailyNotes();

        private string _newOne = "";
        public string NewOne        //need to perform that action for every value from ObservableCollection
        {
            get { return _newOne; }
            set
            {
                if(_newOne != value)
                {
                   // dailyNotes.deleteNote(dailyNotes.GetNoteId(value));

                    _newOne = value;
                    dailyNotes.addNote(_newOne);
                    dailyNotes.SaveNotes();
                    OnPropertyChanged("NewOne");
                }
            }
        }

        public ObservableCollection<string> NotesList
        {
            get { return _notesList; }
            set
            {
                if(_notesList != value)
                {
                    _notesList = value;
                    OnPropertyChanged("NotesList");
                    _notesList.Add("");
                }
            }
        }
        public NotesViewAViewModel(NotesDataProvider notesDataProvider)
        {
            _notesList.Add("ddd");
        
        }


    }
}
