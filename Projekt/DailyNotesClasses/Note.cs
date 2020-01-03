using System;

namespace DailyNotesClasses
{
    public class Note
    {
        public string Content { get; set; }
        public string PublicationDate { get; set; }

        public Note(string _content)
        {
            this.Content = _content;
            this.PublicationDate = DateTime.Now.ToString("yyyy-MM-dd");
        }

        public override string ToString()
        {
            return $"{PublicationDate}: {Content}";
        }
    }
}
