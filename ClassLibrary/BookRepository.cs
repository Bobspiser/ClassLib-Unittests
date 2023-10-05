using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class BookRepository
    {
        private List<Book> _books = new List<Book>()
        {
            (new Book(1, "Uni", 200)),
            (new Book(2, "Uno", 235)),
            (new Book(3, "Onion", 250)),
            (new Book(4, "Godzilla", 125)),
            (new Book(5, "Batman", 145))
        };

        public List<Book> GetAllBooks()
        {
            return new List<Book>(_books);
        }

        public Book GetFilterPrice()
        {
            foreach (var x in _books)
            {
                if(200 <= x.Price)
                {
                    return x;
                }

            }
            throw new Exception("Der findes ingen bøger under 200 kr.");
        }

        public Book GetSortTP()
        {
            Array.Sort((Array)_books.OrderBy(x => x.Price));
            Array.Sort((Array)_books.OrderBy(x => x.Title));

            foreach (var x in _books)
            {
                return x;
            }

            throw new Exception("Det er ikke muligt at sortere i pris og title");
        }

        public Book GetById(int id)
        {
            foreach (Book b in _books)
            {
                if (b.Id == id)
                {
                    return b;
                }
            }
            throw new NotImplementedException($"Der er intet med dette id: {id}");
        }

        public Book Add(Book book)
        {
            _books.Add(book);
            return book;
        }

        public Book Delete(int id)
        {
            Book book = GetById(id);

            _books.Remove(book);

            return book;
        }

        public void Update(int id, Book values)
        {
            var b = GetById(id);
            b.Title = values.Title;
            b.Price = values.Price;
        }
    }

}
