using Microsoft.VisualStudio.TestTools.UnitTesting;
using DailyNotesClasses;
using System;

namespace ProjektTests
{
    [TestClass]
    public class DailyNotesTests
    {
        [TestMethod]
        public void Note_Create_Correct_Note()
        {
            Note note = new Note(1, "Test Note");
            Assert.AreEqual("Test Note", note.Content);
        }
        [TestMethod]
        public void Note_Exception_Content_Too_Long()
        {
            string content = "";
            for (int i = 0; i < 400; i++)
            {
                content = content + i.ToString();
            }
            Assert.ThrowsException<ArgumentException>(() => new Note(1, content));
        }

        [TestMethod]
        public void Read_Note_From_List()
        {
            DailyNotes instance = new DailyNotes();
            instance.addNote("First Note");
            instance.addNote("Second Note");
            Assert.AreEqual("Second Note", instance.Notes[1].Content);
        }
        [TestMethod]
        public void Note_List_Too_Long()
        {
            void createList()
            {
                DailyNotes instance = new DailyNotes();

                for (int i = 0; i < 350; i++) instance.addNote($"Note number: {i.ToString()}");

            }
            Assert.ThrowsException<IndexOutOfRangeException>(() => createList());
        }

        [TestMethod]
        public void Delete_Note()
        {
            DailyNotes instance = new DailyNotes();
            instance.addNote("First Note");
            instance.addNote("Second Note");
            instance.deleteNote(1);
            Assert.AreEqual("Second Note", instance.Notes[0].Content);
        }
    }

}
