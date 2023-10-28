using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeekHub.Domains
{
    public abstract class CommomList
    {
        [Key]
        public string ListId { get; set; }

        public ICollection<Movie> Movies { get; set; }

        [Required]
        public virtual User User { get; set; }

        public virtual string ListName { get; set; }

        public CommomList() { }
    }
}