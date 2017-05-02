using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.DAL
{
    //public class StoreInitializer : System.Data.Entity.CreateDatabaseIfNotExists<StoreContext>
    public class StoreInitializer : System.Data.Entity.DropCreateDatabaseAlways<StoreContext>
    {
        protected override void Seed(StoreContext context)
        {
            var books = new List<Book>
            {
                new Book(){ BookTitle="Ksiazka 1", ISBN="12345"},
                new Book(){ BookTitle="Ksiazka 2", ISBN="67890"}
            };
            books.ForEach(x => context.Books.Add(x));
            context.SaveChanges();

            var authors = new List<Author>
            {
                new Author(){ AuthorName="Michal", AuthorSurname="Wspanialy"},
                new Author(){ AuthorName="Maciej", AuthorSurname="Wielki"}
            };
            authors.ForEach(x => context.Authors.Add(x));
            context.SaveChanges();

            //base.Seed(context);
        }
    }
}