using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.Models
{
    public class BookstoreContext : DbContext
    {
        public BookstoreContext()
        {

        }

        public BookstoreContext(DbContextOptions<BookstoreContext> options)
            : base(options)
        {
        }
        public DbSet<Bookstores> Books { get; set; }

        public DbSet<Purchase> Purch { get; set; }

        protected override void OnModelCreating(ModelBuilder some_name)
        {
            some_name.Entity<Bookstores>().HasData(

                new Bookstores
                {
                    BookID = 1,
                    Title = "Harry Potter and the Sorcerers Stone",
                    Author = "JK Rowling",
                    Publisher = "Commonhouse Publishing",
                    ISBN = "0590353403",
                    Classification = "Action",
                    Category = "Fantasy",
                    PageCount = 145,
                    Price = 20.01
                },

                 new Bookstores
                 {
                     BookID = 2,
                     Title = "Harry Potter and the Twlilight Princess",
                     Author = "JK Rowling",
                     Publisher = "Commonhouse Publishing",
                     ISBN = "0590353405",
                     Classification = "Action",
                     Category = "Fantasy +",
                     PageCount = 145,
                     Price = 20.01

                 },


                 new Bookstores
                 {
                     BookID = 3,
                     Title = "50 Shades of Trash",
                     Author = "Trashy Bashy",
                     Publisher = "Strangehouse Publishing",
                     ISBN = "0570353405",
                     Classification = "Romance",
                     Category = "Romance",
                     PageCount = 1,
                     Price = 300.45

                 }

                 );
        }
    }

}
