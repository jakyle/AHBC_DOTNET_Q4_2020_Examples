using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class MovieVM
    {
        [Required]
        public string MovieName { get; set; }

        [Required]
        public string MovieGenre { get; set; }
    }
}
