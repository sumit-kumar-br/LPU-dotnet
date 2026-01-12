using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class LibrarySystem: ILibrarySystem
    {
        private Dictionary<IBook, int> _books = new Dictionary<IBook, int>();
        public void AddBook(IBook book, int quantity)
        {
            if (_books.ContainsKey(book))
                _books[book] += quantity;
            else
                _books[book] = quantity;
        }
        public bool RemoveBook(IBook book, int quantity)
        {
            if (_books.ContainsKey(book))
            {
                _books[book] -= quantity;
                if (_books[book] <= 0)
                {
                    _books.Remove(book);
                }
                return true;
            }
            return false;
        }
        public int CalculateTotal()
        {
            return _books.Sum(f => f.Key.Price * f.Value);
        }

        public List<(string Title, int Quantity, int Price)> BooksInfo()
        {
            throw new NotImplementedException();
        }

        

        public List<(string Category, string Author, int TotalQuantity)> CategoryAndAuthorWithCount()
        {
            throw new NotImplementedException();
        }

        public List<(string Category, int TotalPrice)> CategoryTotalPrice()
        {
            throw new NotImplementedException();
        }

        
    }
}
