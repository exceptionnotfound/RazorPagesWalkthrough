using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesWalkthrough.Web.DataContext
{
    public class BoardGamesDbContext : DbContext
    {
        public BoardGamesDbContext(DbContextOptions<BoardGamesDbContext> options)
            : base(options)
        {
        }

        public DbSet<Models.BoardGame> BoardGames { get; set; }
    }
}
