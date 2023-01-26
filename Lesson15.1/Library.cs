using System;
namespace Lesson15._1
{
	public class Library
	{
		private string name;
		private Book[] books;
		private int numberOfBooks;

        public string Name { get => name; set => name = value; }

		public Library( string name, int maxBookCount)
		{
			this.name = name;
			books = new Book[maxBookCount];
		}

		public void AddNewBook(Book book)
		{
			book.Library = this;
			books[numberOfBooks] = book;
			numberOfBooks++;
		}

		public bool GetBook(int bookIndex, ref Book book)
		{
			if (bookIndex > 0 && bookIndex <= numberOfBooks  )
			{
				book = books[bookIndex - 1];
				return true;
			}
			return false;
		}

		public void FindByTitle(string title)
		{
			for (int i = 0; i < numberOfBooks; i++)
			{
				if (books[i].Title.ToLower().Contains(title.ToLower()))
				{
					Console.WriteLine(i + 1 + " " + books[i].GetInfo());

				}
			}
		}
    }
}

