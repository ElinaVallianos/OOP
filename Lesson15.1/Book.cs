using System;
namespace Lesson15._1
{
	public class Book
	{
		private string author;
		private string title;
		private int pages;
        private Library library;

        public string Author { get => author; }
        public string Title { get => title; }
        public int Pages { get => pages; }
        public Library Library { get => library; set => library = value; }

        public Book(string author, string title, int pages)
        {
            this.author = author;
            this.title = title;
            this.pages = pages;
        }

        public string GetInfo()
        {
            return $"{author} - {title}, {pages} pages.";
        }
    }
}

