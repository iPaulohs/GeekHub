using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeekHub.Domains
{
    public class FavoritesListAssociation
    {
        [Key]
        public string AssociationId { get; set; }

        [ForeignKey("ListId")]
        public string ListId { get; set; }

        public FavoritesListMovies FavoritesList { get; set; }

        public FavoritesListAssociation() { }
    }
}
