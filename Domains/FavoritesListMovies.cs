using System.ComponentModel.DataAnnotations;

namespace GeekHub.Domains
{
    public class FavoritesListMovies : CommomList
    {

        [Required]
        [StringLength(120)]
        public override string ListName { get; set; }

        public FavoritesListMovies() { }
    }
}
