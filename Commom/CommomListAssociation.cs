using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeekHub.Domains
{
    public abstract class CommomListAssociation
    {
        [Required]
        public int MovieId { get; set; }

        [ForeignKey("MovieId")]
        public Movie Movie { get; set; }

        [Required]
        public string ListId { get; set; }

        public CommomListAssociation() { }
    }
}
