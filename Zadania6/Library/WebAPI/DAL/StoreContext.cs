using Library.Models;
using System.Data.Entity;

namespace WebAPI.DAL
{
    public class StoreContext : System.Data.Entity.DbContext
    {
        public StoreContext()
            : base("StoreContext")
        {
            //Database.SetInitializer<StoreContext>(new CreateDatabaseIfNotExists<StoreContext>());
            //Database.SetInitializer<StoreContext>(new MigrateDatabaseToLatestVersion<StoreContext, Configuration>());
            //Database.SetInitializer<StoreContext>(new DropCreateDatabaseAlways<StoreContext>());
            //Configuration.LazyLoadingEnabled = false;
            //Configuration.ProxyCreationEnabled = false;
        }

        public System.Data.Entity.DbSet<Author> Authors { get; set; }
        public System.Data.Entity.DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public");
            base.OnModelCreating(modelBuilder);
        }
    }
}