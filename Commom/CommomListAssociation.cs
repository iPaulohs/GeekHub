using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeekHub.Domains
{
    public abstract class CommomListAssociation
    {
        [ForeignKey("MovieId")]
        public Movie Movie { get; set; }

        [Required]
        public string Id { get; set; }

        public CommomListAssociation() { }
    }
}
