using System.ComponentModel.DataAnnotations;

namespace GeekHub.Domains
{
    public class GeneralListMovies : CommomList 
    {
        [Required]
        [MaxLength(50)]
        public override string ListName { get; set; } 

        public GeneralListMovies(User user)
        {
            ListId = $"<<GENERAL_LIST_ID>>@<<{new Guid(Guid.NewGuid().ToString())}>>";
            Movies = new List<Movie>();
            User = $"<<{user.UserId}>>@<<{user.Username}";
            ListName = $"<<GENERAL_LIST_NAME>>@<<{user.UserId}>>";
        }

        public GeneralListMovies() { }
    }
}
