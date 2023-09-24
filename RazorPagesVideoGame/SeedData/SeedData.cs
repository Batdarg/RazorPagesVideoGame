using Microsoft.EntityFrameworkCore;
using RazorPagesVideoGame.Data;
using RazorPagesVideoGame.Models;

namespace RazorPagesVideoGame.SeedData
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesVideoGameContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorPagesVideoGameContext>>()))
            {
                if (context == null || context.VideoGame == null)
                {
                    throw new ArgumentNullException("Null RazorPagesMovieContext");
                }

                // Look for any movies.
                if (context.VideoGame.Any())
                {
                    return;   // DB has been seeded
                }

                context.VideoGame.AddRange(
                    new VideoGame
                    {
                        Title = "Jedi Survivor",
                        Genre = "Action",
                        Studio = "Electronic Arts Inc",
                        Rating = "B15",
                        Platform = "PS5",
                        ReleaseDate = DateTime.Parse("2023-4-27"),
                        Price = 69.99M
                    },
                    new VideoGame
                    {
                        Title = "Hogwarts Legacy",
                        Genre = "Unique",
                        Studio = "Warner Bros. Interactive",
                        Rating = "B15",
                        Platform = "PS5",
                        ReleaseDate = DateTime.Parse("2023-2-10"),
                        Price = 69.99M
                    },
                    new VideoGame
                    {
                        Title = "ELDEN RING",
                        Genre = "RPG",
                        Studio = "Bandai Namco Entertainment America Inc",
                        Rating = "C",
                        Platform = "PS5",
                        ReleaseDate = DateTime.Parse("2022-2-25"),
                        Price = 59.99M
                    },
                    new VideoGame
                    {
                        Title = "Captain Tsubasa: Rise of New Champions",
                        Genre = "Sport",
                        Studio = "Bandai Namco Entertainment America Inc",
                        Rating = "A",
                        Platform = "PS4",
                        ReleaseDate = DateTime.Parse("2020-8-27"),
                        Price = 39.99M
                    },
                    new VideoGame
                    {
                        Title = "It Takes Two",
                        Genre = "Unique",
                        Studio = "Electronic Arts Inc",
                        Rating = "B15",
                        Platform = "PS5",
                        ReleaseDate = DateTime.Parse("2021-3-26"),
                        Price = 39.99M
                    },
                    new VideoGame
                    {
                        Title = "Mortal Kombat 11",
                        Genre = "Fighting",
                        Studio = "Warner Bros. Interactive",
                        Rating = "C",
                        Platform = "PS5",
                        ReleaseDate = DateTime.Parse("2020-11-17"),
                        Price = 49.99M
                    },
                    new VideoGame
                    {
                        Title = "A Plague Tale: Requiem",
                        Genre = "Adventure",
                        Studio = "Focus Entertainment",
                        Rating = "C",
                        Platform = "PS5",
                        ReleaseDate = DateTime.Parse("2022-10-17"),
                        Price = 35.99M
                    },
                    new VideoGame
                    {
                        Title = "A Plague Tale: Innocence",
                        Genre = "Adventure",
                        Studio = "Focus Entertainment",
                        Rating = "C",
                        Platform = "PS5",
                        ReleaseDate = DateTime.Parse("2021-7-5"),
                        Price = 39.99M
                    },
                    new VideoGame
                    {
                        Title = "Cyberpunk 2077",
                        Genre = "Unique",
                        Studio = "CD PROJEKT SA",
                        Rating = "C",
                        Platform = "PS5",
                        ReleaseDate = DateTime.Parse("2022-2-15"),
                        Price = 29.99M
                    },
                    new VideoGame
                    {
                        Title = "God of War Ragnarök",
                        Genre = "Action",
                        Studio = "Sony Interactive Entertainment",
                        Rating = "C",
                        Platform = "PS5",
                        ReleaseDate = DateTime.Parse("2022-8-11"),
                        Price = 69.99M  
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
