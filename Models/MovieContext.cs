using System;
using Microsoft.EntityFrameworkCore;

namespace mission4.Models
{
    public class MovieContext: DbContext
    {
        // constructor
        public MovieContext (DbContextOptions<MovieContext> options) : base (options)
        {
            // leave blank for now
        }

        public DbSet<Application> Responses { get; set; }
        public DbSet<Category> Categories { get; set; }

        // seeding for database
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                new Category { CategoryID = 1, CategoryName= "Action/Adventure" },
                new Category { CategoryID = 2, CategoryName = "Comedy" },
                new Category { CategoryID = 3, CategoryName = "Drama" },
                new Category { CategoryID = 4, CategoryName = "Family" },
                new Category { CategoryID = 5, CategoryName = "Horror/Suspense" },
                new Category { CategoryID = 6, CategoryName = "Family" },
                new Category { CategoryID = 7, CategoryName = "Miscellaneous" },
                new Category { CategoryID = 8, CategoryName = "Television" },
                new Category { CategoryID = 9, CategoryName = "VHS" }
                );

            mb.Entity<Application>().HasData(

                new Application
                {
                    MovieID = 1,
                    CategoryID = 1,
                    Title = "Lord of the Rings: The Fellowship of the Ring",
                    Year = 2001,
                    Director = "Peter Jackson",
                    Rating = "PG-13",
                    Edited = false,
                    Lent = "",
                    Notes = ""
                },
                new Application
                {
                    MovieID = 2,
                    CategoryID = 1,
                    Title = "Lord of the Rings: The Two Towers",
                    Year = 2002,
                    Director = "Peter Jackson",
                    Rating = "PG-13",
                    Edited = false,
                    Lent = "",
                    Notes = ""
                },
                new Application
                {
                    MovieID = 3,
                    CategoryID = 1,
                    Title = "Lord of the Rings: The Return of the King",
                    Year = 2002,
                    Director = "Peter Jackson",
                    Rating = "PG-13",
                    Edited = false,
                    Lent = "",
                    Notes = ""
                },
                 new Application
                 {
                     MovieID = 4,
                     CategoryID = 3,
                     Title = "test",
                     Year = 2022,
                     Director = "Kyle Evert",
                     Rating = "PG",
                     Edited = true,
                     Lent = "David Evert",
                     Notes = "Just a sample here"
                 }


                );
        }
    }
}

