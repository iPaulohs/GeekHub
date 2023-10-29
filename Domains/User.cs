using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeekHub.Domains
{
    public class User : IdentityUser
    {
        [Key]
        [Required]
        public override string? Id { get; set; }

        [Required]
        [StringLength(80)]
        public string? Name { get; set; }

        [Required]
        [StringLength(80)]
        [RegularExpression(@"^[\w-]+(\.[\w-]+)*@[\w-]+(\.[\w-]+)+$", ErrorMessage = "Email format is invalid!")]
        public override string? Email { get; set; }

        [Required]
        [StringLength(45)]
        public string? Password { get; set; }

        [StringLength(14)]
        [RegularExpression(@"^\d{3}\.\d{3}\.\d{3}-\d{2}$")]
        public string CPF {  get; set; }

        [Required]
        [StringLength(25)]
        public override string? UserName { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }

        public ICollection<Movie> Favorites { get; set; } = new List<Movie>();

        public virtual ICollection<GeneralListMovies> GeneralLists { get; set; } = new List<GeneralListMovies>();

        public User() { }
    }
}
