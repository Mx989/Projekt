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

        }
    }
}
