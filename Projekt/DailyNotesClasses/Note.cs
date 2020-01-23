using System;

namespace DailyNotesClasses
{
    public class Note
    {
        public int Id { get; }
        public string Content { get; set; }
        public string PublicationDate { get; set; }

        public Note(int _id = 0, string _content = "")
        {
            
            //if (_content.Trim().Length < 5) throw new ArgumentException("Note length can't be < than 5 characters!");
            if (_content.Trim().Length > 300) throw new ArgumentException("Note length can't be > than 300 characters!");
            if (_id == 0) Id = RandomNumber(0, 9999999);
            else Id = _id;
            this.Content = _content;
            this.PublicationDate = DateTime.Now.ToString("yyyy-MM-dd");
            
        }

        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        public override string ToString()
        {
            return $"{PublicationDate}: {Content}";
        }
    }
}
