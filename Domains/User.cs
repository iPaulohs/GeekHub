using System.ComponentModel.DataAnnotations;

namespace GeekHub.Domains
{
    public class User
    {
        [Key]
        [Required]
        public string UserId { get; set; }

        [Required]
        [MaxLength(80)]
        public string Name { get; set; }

        [Required]
        [MaxLength(40)]
        [RegularExpression(@"^[\w-]+(\.[\w-]+)*@[\w-]+(\.[\w-]+)+$", ErrorMessage = "Email format is invalid!")]
        public string Email { get; set; }

        [Required]
        [MaxLength(25)]
        public string Password { get; set; }

        [Required]
        [MaxLength(25)]
        public string Username { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }

        public FavoritesListMovies FavoriteMovies { get; set; }

        public ICollection<GeneralListMovies>? GeneralListMovies { get; set; }

        public User(string name, string email, string password, string username, DateTime birthDate) 
        {
            UserId = $"<<{Username}>>@<<{new Guid(Guid.NewGuid().ToString())}>>";
            Name = name;
            Email = email;
            Password = password;
            Username = username;
            BirthDate = birthDate;
            FavoriteMovies = new FavoritesListMovies();
            GeneralListMovies = new List<GeneralListMovies>();
        }

        public User() { }
    }
}
