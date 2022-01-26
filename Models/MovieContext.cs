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

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Application>().HasData(

                new Application
                {
                    MovieID = 1,
                    Category = "Action/Adventure",
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
                    Category = "Action/Adventure",
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
                    Category = "Action/Adventure",
                    Title = "Lord of the Rings: The Return of the King",
                    Year = 2002,
                    Director = "Peter Jackson",
                    Rating = "PG-13",
                    Edited = false,
                    Lent = "",
                    Notes = ""
                }


                );
        }
    }
}

