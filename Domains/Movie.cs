using System.ComponentModel.DataAnnotations;

namespace GeekHub.Domains
{
    public class Movie
    {
        [Key]
        [Required]
        public int MovieId { get; set; }

        [Required]
        [StringLength(120)]
        public string Title { get; set; }

        public virtual ICollection<FavoritesListMovies> FavoritesListAssociations { get; set; } = new List<FavoritesListMovies>();

        public virtual ICollection<GeneralListMovies> GeneralListAssociations { get; set; } = new List<GeneralListMovies>();

        public Movie() { }

        public Movie(int movieId, string title)
        {
            MovieId = movieId;
            Title = title;
        }
    }
}
