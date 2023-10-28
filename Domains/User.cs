using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeekHub.Domains
{
    public class User : IdentityUser
    {
        [Key]
        [Required]
        [ForeignKey("UserId")]
        public override string? Id { get; set; }

        [Required]
        [MaxLength(80)]
        public string? Name { get; set; }

        [Required]
        [MaxLength(40)]
        [RegularExpression(@"^[\w-]+(\.[\w-]+)*@[\w-]+(\.[\w-]+)+$", ErrorMessage = "Email format is invalid!")]
        public override string? Email { get; set; }

        [Required]
        [MaxLength(25)]
        public string? Password { get; set; }

        [MaxLength(25)]
        public string CPF {  get; set; }

        [Required]
        [MaxLength(25)]
        public override string? UserName { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }

        public FavoritesListMovies? FavoriteMovies { get; set; }

        public ICollection<GeneralListMovies>? GeneralListMovies { get; set; }

        public User() { }
    }
}
