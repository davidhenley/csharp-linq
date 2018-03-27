using System;
using System.Linq;

namespace LINQ
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();

            // LINQ Extension Methods
            var cheapBooks = books
                .Where(book => book.Price < 10)
                .OrderBy(book => book.Title)
                .Select(book => book.Title);

            // LINQ Query Operators
            var cheaperBooks = from b in books
                               where b.Price < 8
                               orderby b.Title
                               select b.Title;

            Console.WriteLine("Books under $10");
            foreach (var book in cheapBooks) Console.WriteLine(book);

            Console.WriteLine("\nBooks under $8");
            foreach (var book in cheaperBooks) Console.WriteLine(book);
        }
    }
}
