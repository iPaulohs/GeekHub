using System.ComponentModel.DataAnnotations;

namespace GeekHub.Domains
{
    public class GeneralListMovies : CommomList 
    {
        [Required]
        [MaxLength(50)]
        public override string ListName { get; set; }

        public GeneralListMovies() { }
    }
}
