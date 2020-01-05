using System;
using System.Collections.Generic;
using System.Text;

namespace DailyNotesClasses
{
    public class DailyNotes
    {
        public List<Note> Notes { get; }

        public DailyNotes()
        {
            Notes = new List<Note>();

        }

        public void addNote(Note newNote)
        {
            Notes.Add(newNote);
        }

    }
}
