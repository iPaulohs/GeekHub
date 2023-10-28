using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeekHub.Domains
{
    public class Movie
    {
        [Key]
        [Required]
        [ForeignKey("movieId")]
        public int MovieId { get; set; }

        public string Title { get; set; }

        public Movie() { }
    }
}
