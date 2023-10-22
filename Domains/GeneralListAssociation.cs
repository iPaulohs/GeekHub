using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeekHub.Domains
{
    public class GeneralListAssociation
    {
        [Key]
        public string AssociationId { get; set; }

        [ForeignKey("ListId")]
        public string ListId { get; set; }

        public GeneralListMovies GeneralList { get; set; }

        public GeneralListAssociation() { }
    }
}