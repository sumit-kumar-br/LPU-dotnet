using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class Book: IBook
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Category { get; set; }
        public int Price { get; set; }
        public Book() { }
        public Book(int id, string title, string author, string category, int price)
        {
            Id = id;
            Title = title;
            Author = author;
            Category = category;
            Price = price;
        }

    }
}
