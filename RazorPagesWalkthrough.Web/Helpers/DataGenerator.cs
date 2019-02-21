using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RazorPagesWalkthrough.Web.DataContext;
using RazorPagesWalkthrough.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesWalkthrough.Web.Helpers
{
    /// <summary>
    /// This class is not intended as part of the walkthrough.  Rather, it is used to generate a
    /// sample set of board games.
    /// </summary>
    public class DataGenerator
    {

        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new BoardGamesDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<BoardGamesDbContext>>()))
            {
                // Look for any board games already in database.
                if (context.BoardGames.Any())
                {
                    return;   // Database has been seeded
                }

                context.BoardGames.AddRange(
                    new BoardGame
                    {
                        ID = 1,
                        Title = "Candy Land",
                        PublishingCompany = "Hasbro",
                        MinPlayers = 2,
                        MaxPlayers = 4
                    },
                    new BoardGame
                    {
                        ID = 2,
                        Title = "Sorry!",
                        PublishingCompany = "Hasbro",
                        MinPlayers = 2,
                        MaxPlayers = 4
                    },
                    new BoardGame
                    {
                        ID = 3,
                        Title = "Ticket to Ride",
                        PublishingCompany = "Days of Wonder",
                        MinPlayers = 2,
                        MaxPlayers = 5
                    },
                    new BoardGame
                    {
                        ID = 4,
                        Title = "The Settlers of Catan (Expanded)",
                        PublishingCompany = "Catan Studio",
                        MinPlayers = 2,
                        MaxPlayers = 6
                    },
                    new BoardGame
                    {
                        ID = 5,
                        Title = "Carcasonne",
                        PublishingCompany = "Z-Man Games",
                        MinPlayers = 2,
                        MaxPlayers = 5
                    },
                    new BoardGame
                    {
                        ID = 6,
                        Title = "Sequence",
                        PublishingCompany = "Jax Games",
                        MinPlayers = 2,
                        MaxPlayers = 6
                    });

                context.SaveChanges();
            }
        }
    }
}
