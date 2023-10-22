using System.ComponentModel.DataAnnotations;

namespace GeekHub.Domains
{
    public class Movie
    {
        [Key]
        [Required]
        public int MovieId { get; set; }

        public string Title { get; set; }

        public Movie() { }
    }
}
