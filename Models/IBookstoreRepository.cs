using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.Models
{
    public interface IBookstoreRepository
    {
        IQueryable<Bookstores> Books { get; }

        public void SaveBook(Bookstores p);
        public void CreateBook(Bookstores p);
        public void DeleteBook(Bookstores p);
    }

}
