using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.Models
{
    public class EFBookstoreRepository : IBookstoreRepository
    {
        private BookstoreContext context { get; set; }
        public EFBookstoreRepository (BookstoreContext temp)
        {
            context = temp;
        }

        public IQueryable<Bookstores> Books => context.Books;

        public void SaveBook(Bookstores p)
        {
            context.SaveChanges();
        }

        public void CreateBook(Bookstores p)
        {
            context.Add(p);
            context.SaveChanges();
        }

        public void DeleteBook(Bookstores p)
        {
            context.Remove(p);
            context.SaveChanges();
        }
    }
}
