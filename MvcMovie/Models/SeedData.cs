using Elfie.Serialization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MvcMovieContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MvcMovieContext>>()))
        {
            // Look for any movies.
            if (context.Movie.Any())
            {
                return;   // DB has been seeded
            }
            context.Movie.AddRange(
                new Movie
                {
                    Title = "The Best Two Years",
                    ReleaseDate = DateTime.Parse("2004-2-20"),
                    Genre = "Comedy",
                    Rating = "PG",
                    Price = 25.00M
                },
                new Movie
                {
                    Title = "17 Miracles",
                    ReleaseDate = DateTime.Parse("2011-6-03"),
                    Genre = "Adventure",
                    Rating = "PG",
                    Price = 11.67M
                },
                new Movie
                {
                    Title = "The Saratov Approach",
                    ReleaseDate = DateTime.Parse("2013-10-09"),
                    Genre = "Action",
                    Rating = "PG-13",
                    Price = 8.61M
                },
                new Movie
                {
                    Title = "The R.M.",
                    ReleaseDate = DateTime.Parse("2003-1-31"),
                    Genre = "Comedy",
                    Rating = "PG",
                    Price = 10.70M
                },
                new Movie
                {
                    Title = "The Cokeville Miracle",
                    ReleaseDate = DateTime.Parse("2015-6-05"),
                    Genre = "Drama",
                    Rating = "PG-13",
                    Price = 11.99M
                },
                new Movie
                {
                    Title = "Forever Strong",
                    ReleaseDate = DateTime.Parse("2008-9-26"),
                    Genre = "Drama",
                    Rating = "PG-13",
                    Price = 6.96M
                }
            );
            context.SaveChanges();
        }
    }
}
