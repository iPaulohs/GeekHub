using System.ComponentModel.DataAnnotations;

namespace GeekHub.Domains
{
    public class FavoritesListMovies : CommomList
    {

        [Required]
        [MaxLength(50)]
        public override string ListName { get; set; } = "Favorites";

        public FavoritesListMovies(User user)
        {
            ListId = $"<<FAVORITES_LIST_ID>>@[{new Guid(Guid.NewGuid().ToString())}]>>";
            Movies = new List<Movie>();
            User = $"<<{user.UserId}>>@<<{user.Username}";
            ListName = $"FAVORITES_LIST_NAME::[{user.UserId}]" ;
        }

        public FavoritesListMovies() { }
    }
}
