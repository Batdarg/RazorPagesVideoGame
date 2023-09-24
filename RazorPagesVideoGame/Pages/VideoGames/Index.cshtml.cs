using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using RazorPagesVideoGame.Data;
using RazorPagesVideoGame.Models;

namespace RazorPagesVideoGame.Pages.VideoGames
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesVideoGame.Data.RazorPagesVideoGameContext _context;

        public IndexModel(RazorPagesVideoGame.Data.RazorPagesVideoGameContext context)
        {
            _context = context;
        }

        public IList<VideoGame> VideoGame { get; set; } = default!;

        [BindProperty(SupportsGet = true)]
        public string? SearchString { get; set; }

        public SelectList? Genres { get; set; }

        [BindProperty(SupportsGet = true)]
        public string? VideoGameGenre { get; set; }
        public decimal total { get; set; }

        public async Task OnGetAsync()
        {
            // Use LINQ to get list of genres.
            IQueryable<string> genreQuery = from m in _context.VideoGame
                                            orderby m.Genre
                                            select m.Genre;

            var result = from m in _context.VideoGame
                        select m;

            var videogames = from m in _context.VideoGame
                             select m;

            total = videogames.Sum(x => x.Price);

            if (!string.IsNullOrEmpty(SearchString))
            {
                videogames = videogames.Where(s => s.Title.Contains(SearchString));
                total = videogames.Sum(x => x.Price);
            }

            if (!string.IsNullOrEmpty(VideoGameGenre))
            {
                videogames = videogames.Where(x => x.Genre == VideoGameGenre);
                total = videogames.Sum(x => x.Price);
            }
 
            Genres = new SelectList(await genreQuery.Distinct().ToListAsync());
            VideoGame = await videogames.ToListAsync();
        }
    }
}
