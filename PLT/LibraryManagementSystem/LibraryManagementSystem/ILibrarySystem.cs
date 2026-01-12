using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public interface ILibrarySystem
    {
        void AddBook(IBook book, int quantity);
        bool RemoveBook(IBook book, int quantity);
        int CalculateTotal();
        List<(string Category, int TotalPrice)> CategoryTotalPrice();
        List<(string Title, int Quantity, int Price)> BooksInfo();
        List<(string Category, string Author, int TotalQuantity)> CategoryAndAuthorWithCount();

    }
}
