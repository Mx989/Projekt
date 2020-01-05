using System;

namespace DailyNotesClasses
{
    public class Note
    {
        public int Id { get; }
        public string Content { get; set; }
        public string PublicationDate { get; set; }

        public Note(int _id,string _content)
        {
            try
            {
                if (_content.Trim().Length < 5) throw new ArgumentException("Note length can't be lower than 5 characters!");

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            this.Id = _id;
            this.Content = _content;
            this.PublicationDate = DateTime.Now.ToString("yyyy-MM-dd");
        }

        public override string ToString()
        {
            return $"{PublicationDate}: {Content}";
        }
    }
}
