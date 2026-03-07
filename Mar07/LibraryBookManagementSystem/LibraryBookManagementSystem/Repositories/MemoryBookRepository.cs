using LibraryBookManagementSystem.Models;

namespace LibraryBookManagementSystem.Repositories
{
    public class MemoryBookRepository : IBookRepository
    {
        private List<Book> books;

        public MemoryBookRepository()
        {
            books = new List<Book>()
            {
                new Book { BookId = 1, Title = "Clean Code", Author = "Robert C. Martin", Price = 500 },
                new Book { BookId = 2, Title = "Design Patterns", Author = "GoF", Price = 700 },
                new Book { BookId = 3, Title = "Refactoring", Author = "Martin Fowler", Price = 650 }
            };
        }

        public IEnumerable<Book> GetAllBooks()
        {
            return books;
        }

        public Book GetBookById(int id)
        {
            return books.FirstOrDefault(b => b.BookId == id);
        }

        public void AddBook(Book book)
        {
            book.BookId = books.Max(b => b.BookId) + 1;
            books.Add(book);
        }

        public void DeleteBook(int id)
        {
            var book = books.FirstOrDefault(b => b.BookId == id);

            if (book != null)
            {
                books.Remove(book);
            }
        }

        public void UpdateBook(Book book)
        {
            var existingBook = books.FirstOrDefault(b => b.BookId == book.BookId);

            if (existingBook != null)
            {
                existingBook.Title = book.Title;
                existingBook.Author = book.Author;
                existingBook.Price = book.Price;
            }
        }
    }
}