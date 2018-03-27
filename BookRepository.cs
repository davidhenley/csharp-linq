using System;
using System.Collections.Generic;

namespace LINQ
{
    public class BookRepository
    {
        public IEnumerable<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book() { Title = "ADO.NET Step by Step", Price = 5m },
                new Book() { Title = "ADO.NET MVC", Price = 9.99m },
                new Book() { Title = "ADO.NET Web API", Price = 12m },
                new Book() { Title = "C# Advanced Topics", Price = 7m },
                new Book() { Title = "C# Advanced Topics", Price = 9m }
            };
        }
    }
}
