using DailyNotesClasses;
using System;

namespace DailyNotesConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            DailyNotes notesList = new DailyNotes();
            Console.WriteLine(notesList.Notes.Count);

           var note = new Note(1, "T", "23-01-2020");
           Console.WriteLine(note);

        }
    }
}
