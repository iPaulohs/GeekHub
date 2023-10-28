using System.ComponentModel.DataAnnotations;

namespace GeekHub.Domains
{
    public class FavoritesListAssociation
    {
        [Key]
        public string AssociationId { get; set; }

        public FavoritesListMovies FavoritesList { get; set; }

        public Movie Movie { get; set; }

        public FavoritesListAssociation() { }
    }
}
