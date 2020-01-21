using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DailyNotesClasses;

namespace WpfApp.DataProviders
{
    public class NotesDataProvider : DataProviderBase
    {
        private DailyNotes _notesList = new DailyNotes();

        

        public NotesDataProvider()
        {
            //NotesList = _notesList.addNote("aaa");
        }
    }
}
