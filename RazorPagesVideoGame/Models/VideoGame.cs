using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesVideoGame.Models
{
    public class VideoGame
    {
        public int Id { get; set; }
        public string? Title { get; set; } = string.Empty;
        public string? Genre { get; set; } = string.Empty;
        public string? Studio { get; set; } = string.Empty;
        public string? Rating { get; set; } = string.Empty;
        public string? Platform { get; set; } = string.Empty;
        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
    }
}
