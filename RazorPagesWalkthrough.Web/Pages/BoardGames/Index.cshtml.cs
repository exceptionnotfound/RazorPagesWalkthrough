using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesWalkthrough.Web.DataContext;
using RazorPagesWalkthrough.Web.Models;

namespace RazorPagesWalkthrough.Web.Pages.BoardGames
{
    public class IndexModel : PageModel
    {
        private BoardGamesDbContext _context;

        public IndexModel(BoardGamesDbContext context)
        {
            _context = context;
        }

        public List<BoardGame> BoardGames { get; set; }

        public void OnGet()
        {
            BoardGames = _context.BoardGames.ToList();
        }
    }
}