using System.ComponentModel.DataAnnotations;

namespace GeekHub.Domains
{
    public class FavoritesListMovies : CommomList
    {

        [Required]
        public override string ListName { get; set; } = "Favorites";

        public FavoritesListMovies() { }
    }
}
