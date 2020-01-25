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
        #region Properties
        private ObservableCollection<Note> _notesList = new ObservableCollection<Note>();
        DailyNotes dailyNotes = new DailyNotes();

        public ObservableCollection<Note> NotesList
        {
            get { return _notesList; }
        }
        #endregion

        #region Constructor
        public NotesViewAViewModel()
        {
            LoadNotes();
        }

        public void LoadNotes()
        {
            foreach (var note in dailyNotes.Notes)
            {
                _notesList.Add(note);
            }
        }
        #endregion
        
        #region Commands

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
            _notesList.Add(new Note());
            OnPropertyChanged("NotesList");
        }

        private ICommand _saveNotesCommand;

        public object SaveNotesCommand
        {
            get
            {
                return _saveNotesCommand ?? (_saveNotesCommand = new RelayCommand(
                    x =>
                    {
                        SaveNotes();
                    }));
            }
        }

        public void SaveNotes()
        {
            dailyNotes.DeleteAllNotes();
            foreach(var note in NotesList)
            {
                dailyNotes.addNote(note.Content);
            }
            dailyNotes.SaveNotes();
            OnPropertyChanged("NotesList");
        }


        private ICommand _deleteNotesCommand;

        public object DeleteNotesCommand
        {
            get
            {
                return _deleteNotesCommand ?? (_deleteNotesCommand = new RelayCommand(
                    x =>
                    {
                        DeleteNotes();
                    }));
            }
        }

        public void DeleteNotes()
        {
            _notesList.Clear();
            dailyNotes.DeleteAllNotes();
            dailyNotes.SaveNotes();
            OnPropertyChanged("NotesList");
        }
        #endregion
    }
}
