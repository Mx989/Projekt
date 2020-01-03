using System;

namespace DailyNotesClasses
{
    public class Note
    {
        public string Content { get; set; }

        public Note(string _content)
        {
            this.Content = _content;
        }
    }
}
