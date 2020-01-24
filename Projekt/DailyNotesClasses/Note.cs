using System;

namespace DailyNotesClasses
{
    public class Note
    {
        //unique Id of the note 
        public int Id { get; }
        //Content of the note
        public string Content { get; set; }

        //Date on which the note was publicated
        public string PublicationDate { get; set; }

        //Constructor creates Note
        public Note(int _id = 0, string _content = "")
        {
            
            if (_content.Trim().Length > 300) throw new ArgumentException("Note length can't be > than 300 characters!");
            this.Id = _id;
            this.Content = _content;
            this.PublicationDate = DateTime.Now.ToString("yyyy-MM-dd");
            
        }

        //Returns Note as String
        public override string ToString()
        {
            return $"{PublicationDate}: {Content}";
        }
    }
}
