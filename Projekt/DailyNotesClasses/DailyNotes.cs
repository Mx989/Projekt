using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


namespace DailyNotesClasses
{
    public class DailyNotes
    {
        public List<Note> Notes { get; set; }
        private string SavePath = Directory.GetCurrentDirectory() + "\\test.txt";
        public DailyNotes()
        {
            Notes = new List<Note>();
            LoadNotes();
        }

        public void addNote(string content)
        {
                CheckLength();
                Notes.Add(new Note(Notes.Count,content));
        }

        public void deleteNote(int noteId)
        {
            Notes.RemoveAll(x => x.Id == noteId);
        }

        public void DeleteAllNotes()
        {
            Notes = new List<Note>();
            SaveNotes();
        }

        private void CheckLength()
        {
            if (Notes.Count > 300) throw new IndexOutOfRangeException("Maximum amount of Notes is 300");
        }

        public int GetNoteId(string content)
        {
            return (Notes.Find(x => x.Content == content)).Id;
        }

        public bool NoteOnThatIdExist(int id)
        {
            return (Notes.Find(x => x.Id == id)) != null;
        }

        public void SaveNotes()
        {
            using (StreamWriter sw = File.CreateText(SavePath))
            {
                foreach (Note singleNote in Notes)
                {
                    sw.WriteLine($"Id: {singleNote.Id}");
                    sw.WriteLine($"Date: {singleNote.PublicationDate}");
                    sw.WriteLine($"Content: {singleNote.Content}");
                    sw.WriteLine("---");
                }
            }
        }

        private void LoadNotes()
        {
            if (File.Exists(SavePath))
            {
                using (StreamReader sr = File.OpenText(SavePath))
                {
                    string id = "";
                    string publicationDate = "";
                    string content = "";
                    string line = "";

                    while ((line = sr.ReadLine()) != null)
                    {
                        if (line.Substring(0, 1) == "-") Notes.Add(new Note(int.Parse(id), content));
                        else if (line.Substring(0, 2) == "Id") id = line.Substring(4).TrimEnd();
                        else if (line.Substring(0, 4) == "Date") publicationDate = line.Substring(6).TrimEnd();
                        else if (line.Substring(0, 7) == "Content") content = line.Substring(9).TrimEnd();
                    }
                }

            }
        }




    }
}
