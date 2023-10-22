using System.ComponentModel.DataAnnotations;

namespace GeekHub.Domains
{
    public abstract class CommomList
    {
        [Key]
        public string ListId { get; set; }

        public ICollection<Movie> Movies { get; set; }

        [Required]
        public string User { get; set; }

        public virtual string ListName { get; set; }

        public CommomList() { }
    }
}