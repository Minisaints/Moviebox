namespace MovieBox.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<MovieBox.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "MovieBox.Models.ApplicationDbContext";
        }

        protected override void Seed(MovieBox.Models.ApplicationDbContext context)
        {
            //This method will be called after migrating to the latest version.
            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.E.g.
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );

            //context.Movies.AddOrUpdate(
            //      p => p.Name,
            //      new Movie { Name = "Shrek", GenreId = 6, ReleaseDate = DateTime.Parse("13/12/2012"), DateAdded = DateTime.Now, Stock = 3 },
            //      new Movie { Name = "Die Hard 2", GenreId = 2, ReleaseDate = DateTime.Parse("1/1/2018"), DateAdded = DateTime.Now, Stock = 1 },
            //      new Movie { Name = "The GodFather", GenreId = 4, ReleaseDate = DateTime.Parse("23/5/1995"), DateAdded = DateTime.Now, Stock = 34 },
            //      new Movie { Name = "Saw", GenreId = 3, ReleaseDate = DateTime.Parse("6/7/2002"), DateAdded = DateTime.Now, Stock = 6 },
            //      new Movie { Name = "What Lies Beneath", GenreId = 5, ReleaseDate = DateTime.Parse("20/9/2005"), DateAdded = DateTime.Now, Stock = 9 },
            //      new Movie { Name = "Mortal Kombat", GenreId = 2, ReleaseDate = DateTime.Parse("30/4/1992"), DateAdded = DateTime.Now, Stock = 15 },
            //      new Movie { Name = "Knocked Up", GenreId = 1, ReleaseDate = DateTime.Parse("31/3/2013"), DateAdded = DateTime.Now, Stock = 7 }
            //    );
        }
    }
<<<<<<< HEAD
}
=======
}
>>>>>>> 9571c89b8f2096dfc4c400bc6edff1b4871fe012
