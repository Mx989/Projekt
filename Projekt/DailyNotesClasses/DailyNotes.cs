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
            try
            {
                checkLength();
                Notes.Add(newNote);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private void checkLength()
        {
            if (Notes.Count > 300) throw new IndexOutOfRangeException("Maximum amount of Notes is 300");
        }


    }
}
