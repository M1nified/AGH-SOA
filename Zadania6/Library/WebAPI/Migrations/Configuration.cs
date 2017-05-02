namespace WebAPI.Migrations
{
    using Library.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WebAPI.DAL.StoreContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WebAPI.DAL.StoreContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //


            var books = new List<Book>
            {
                new Book(){ BookTitle="Ksiazka 1", ISBN="12345", PageCount=30},
                new Book(){ BookTitle="Ksiazka 2", ISBN="67890", PageCount=534}
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
        }
    }
}
