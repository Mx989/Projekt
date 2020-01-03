using DailyNotesClasses;
using System;

namespace DailyNotesConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Note note1 = new Note("test");
            Console.WriteLine(note1.Content);
        }
    }
}
