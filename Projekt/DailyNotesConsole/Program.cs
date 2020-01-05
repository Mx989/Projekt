using DailyNotesClasses;
using System;

namespace DailyNotesConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            DailyNotes notesList = new DailyNotes();
            notesList.addNote(new Note(1, "blablabla"));

        }
    }
}
