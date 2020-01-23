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
        private ObservableCollection<Note> _notesList = new ObservableCollection<Note>();
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

        public ObservableCollection<Note> NotesList
        {
            get { return _notesList; }
            set
            {
                foreach(var note in value)
                {
                    if (dailyNotes.NoteOnThatIdExist(note.Id))
                    {
                        dailyNotes.deleteNote(note.Id);
                        dailyNotes.addNote(note.Content);
                        dailyNotes.SaveNotes();
                        ReloadNotes();
                        OnPropertyChanged("NotesList");
                    }
                    else
                    {
                        dailyNotes.addNote(note.Content);
                        dailyNotes.SaveNotes();
                        ReloadNotes();
                        OnPropertyChanged("NotesList");
                    }
                }
            }
        }
        public NotesViewAViewModel(NotesDataProvider notesDataProvider)
        {
            ReloadNotes();

            if(_notesList[_notesList.Count-1].Content != "")
            {
                _notesList.Add(new Note(RandomNumber(0, 9999999), ""));
            }
        }

        public void ReloadNotes()
        {
            foreach (var note in dailyNotes.Notes)
            {
                _notesList.Add(note);
            }
        }
        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
        
        private ICommand _addNoteCommand;

        public object AddNoteCommand
        {
            get
            {
                return _addNoteCommand ?? (_addNoteCommand = new RelayCommand(
                    x =>
                    {
                        AddNote();
                    }));
            }
        }

        public void AddNote()
        {
            _notesList.Add(new Note(RandomNumber(0, 9999999), ""));
            OnPropertyChanged("NotesList");
        }
    }
}
