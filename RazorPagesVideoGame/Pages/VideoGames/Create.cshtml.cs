using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPagesVideoGame.Data;
using RazorPagesVideoGame.Models;

namespace RazorPagesVideoGame.Pages.VideoGames
{
    public class CreateModel : PageModel
    {
        private readonly RazorPagesVideoGame.Data.RazorPagesVideoGameContext _context;

        public CreateModel(RazorPagesVideoGame.Data.RazorPagesVideoGameContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public VideoGame VideoGame { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.VideoGame.Add(VideoGame);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
