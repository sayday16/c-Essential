// See https://aka.ms/new-console-template for more information
using System;

namespace task6
{
    public class Book
    {
        public string Title { get; set; }
        public string Content { get; set; }

        public Notes MyNotes { get; set; }

        public Book(string title, string content)
        {
            Title = title;
            Content = content;

            MyNotes = new Notes();
        }

        public void Search(string searchString)
        {
            FindAndReplaceManager.SetCurrentBook(this);
            FindAndReplaceManager.FindNext(searchString);
        }

        public class Notes
        {
            List<string> info = new List<string>();
            public void AddNote(string text)
            {
                info.Add(text);
            }

            public void ShowNotes()
            {
                foreach (var note in info)
                {
                    Console.WriteLine($"- {note}");
                }
            }

        }
    }

    public static class FindAndReplaceManager
    {
        private static Book _currentBook;

        private static int _lastPosition = 0;

        public static void SetCurrentBook(Book book)
        {
            if (book != _currentBook)
            {
                _currentBook = book;
                _lastPosition = 0;
            }
        }

        public static void FindNext(string str)
        {

            if (_currentBook == null)
            {
                Console.WriteLine("null book");
                return;
            }

            int foundIndex = _currentBook.Content.IndexOf(str, _lastPosition);

            if (foundIndex != -1)
            {
                Console.WriteLine($"word {str} found on position: {foundIndex}");
                _lastPosition = foundIndex + str.Length;
            }
            else
            {
                Console.WriteLine("word not found");
                _lastPosition = 0;
            }
        }
    }

    class Program
    {
        static void Main()
        {
            string text = "У норі під землею жив собі гобіт. Це був заможний гобіт, і звали його Більбо.";
            Book myBook = new Book("Гобіт", text);

            myBook.Search("гобіт");
            myBook.Search("гобіт");
            myBook.Search("гобіт");

            Console.WriteLine("---");

            myBook.Search("Більбо");

            Console.WriteLine("Нотатки:");

            myBook.MyNotes.AddNote("Дуже цікавий початок історії!");
            myBook.MyNotes.AddNote("Треба запам'ятати, що гобіти живуть під землею.");
            myBook.MyNotes.AddNote("Головного героя звати Більбо.");

            myBook.MyNotes.ShowNotes();
        }
    }
}
