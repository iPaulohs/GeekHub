using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeekHub.Domains
{
    public abstract class CommomList
    {
        [Key]
        [StringLength(120)]
        public string ListId { get; set; }

        [Required]
        public User User { get; set; }


        public ICollection<Movie> Movies { get; set; } = new List<Movie>();

        public virtual string ListName { get; set; }

        public CommomList() { }
    }
}