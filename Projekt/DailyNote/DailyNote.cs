using System;

namespace DailyNoteLogic
{
    public class DailyNote
    {
        public string Content { get; set; }

        public DailyNote(string _content)
        {
            Content = _content;
        }
    }
}
