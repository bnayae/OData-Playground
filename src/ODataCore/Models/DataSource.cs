using CreateAndFake;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ODataCore
{
    public static class DataSource
    {
        private static IQueryable<Book> _books { get; set; }

        // odata/$metadata#Books
        // odata/Books?$filter=Price le 50
        // odata/Books?$filter=Price le 50&$expand=Press($select=Name)&$select=ISBN
        public static IQueryable<Book> GetBooks()
        {
            if (_books != null)
            {
                return _books;
            }

            var query = from i in Enumerable.Range(0, 1000)
                        select Tools.Randomizer.Create<Book>();
            return query.AsQueryable();

            //var books = new List<Book>();

            //// book #1
            //Book book = new Book
            //{
            //    Id = 1,
            //    ISBN = "978-0-321-87758-1",
            //    Title = "Essential C#5.0",
            //    Author = "Mark Michaelis",
            //    Price = 59.99m,
            //    Location = new Address { City = "Redmond", Street = "156TH AVE NE" },
            //    Press = new Press
            //    {
            //        Id = 1,
            //        Name = "Addison-Wesley",
            //        Category = Category.Book
            //    }
            //};
            //books.Add(book);

            //// book #2
            //book = new Book
            //{
            //    Id = 2,
            //    ISBN = "063-6-920-02371-5",
            //    Title = "Enterprise Games",
            //    Author = "Michael Hugos",
            //    Price = 49.99m,
            //    Location = new Address { City = "Bellevue", Street = "Main ST" },
            //    Press = new Press
            //    {
            //        Id = 2,
            //        Name = "O'Reilly",
            //        Category = Category.EBook,
            //    }
            //};
            //books.Add(book);

            //_books = books.AsQueryable();
            //return _books;
        }
    }
}
