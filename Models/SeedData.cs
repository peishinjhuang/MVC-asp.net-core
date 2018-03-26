using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                     new Movie
                     {
                         Title = "Pacific Rim Uprising",
                         ReleaseDate = DateTime.Parse("2018-3-23"),
                         Genre = "Action",
                         Price = 280
                     },

                     new Movie
                     {
                         Title = "Red Sparrow",
                         ReleaseDate = DateTime.Parse("2018-2-28"),
                         Genre = "Mystery",
                         Price = 310
                     },

                     new Movie
                     {
                         Title = "Isle of Dogs",
                         ReleaseDate = DateTime.Parse("2018-4-1"),
                         Genre = "Comedy",
                         Price = 300
                     },

                   new Movie
                   {
                       Title = "Midnight Sun",
                       ReleaseDate = DateTime.Parse("2018-3-29"),
                       Genre = "Drama",
                       Price = 270
                   },
                   new Movie
                     {
                         Title = "Unsane",
                         ReleaseDate = DateTime.Parse("2018-4-3"),
                         Genre = "Mystery",
                         Price = 295
                     },
                     new Movie
                     {
                         Title = "Sherlock Gnomes",
                         ReleaseDate = DateTime.Parse("2018-4-6"),
                         Genre = "Comedy",
                         Price = 300
                     },new Movie
                     {
                         Title = "Paul, Apostle of Christ",
                         ReleaseDate = DateTime.Parse("2018-3-20"),
                         Genre = "Drama",
                         Price = 290
                     },new Movie
                     {
                         Title = "Hichki",
                         ReleaseDate = DateTime.Parse("2018-4-7"),
                         Genre = "Comedy",
                         Price = 300
                     },new Movie
                     {
                         Title = "Ready Player One ",
                         ReleaseDate = DateTime.Parse("2018-3-29"),
                         Genre = "Action",
                         Price = 315
                     },new Movie
                     {
                         Title = "Tyler Perry's Acrimony ",
                         ReleaseDate = DateTime.Parse("2018-3-30"),
                         Genre = "Drama",
                         Price = 280
                     }
                );
                context.SaveChanges();
            }
        }
    }
}