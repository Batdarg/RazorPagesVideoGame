using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesVideoGame.Models;

namespace RazorPagesVideoGame.Data
{
    public class RazorPagesVideoGameContext : DbContext
    {
        public RazorPagesVideoGameContext (DbContextOptions<RazorPagesVideoGameContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesVideoGame.Models.VideoGame> VideoGame { get; set; } = default!;
    }
}
