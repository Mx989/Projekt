using DailyNotesClasses;
using System;

namespace DailyNotesConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            DailyNotes instance = new DailyNotes();
            instance.addNote("First Note");
            instance.addNote("Second Note");
            instance.deleteNote(1);

            foreach (Note note in instance.Notes)
            {
                Console.WriteLine(note.Id);
            }
        }
    }
}
