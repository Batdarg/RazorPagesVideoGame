﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesVideoGame.Data;
using RazorPagesVideoGame.Models;

namespace RazorPagesVideoGame.Pages.VideoGames
{
    public class DetailsModel : PageModel
    {
        private readonly RazorPagesVideoGame.Data.RazorPagesVideoGameContext _context;

        public DetailsModel(RazorPagesVideoGame.Data.RazorPagesVideoGameContext context)
        {
            _context = context;
        }

        public VideoGame VideoGame { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var videogame = await _context.VideoGame.FirstOrDefaultAsync(m => m.Id == id);
            if (videogame == null)
            {
                return NotFound();
            }
            else
            {
                VideoGame = videogame;
            }
            return Page();
        }
    }
}
