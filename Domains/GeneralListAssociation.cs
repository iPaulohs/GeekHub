using System.ComponentModel.DataAnnotations;

namespace GeekHub.Domains
{
    public class GeneralListAssociation
    {
        [Key]
        public string AssociationId { get; set; }

        public GeneralListMovies GeneralList { get; set; }

        public Movie Movie { get; set; }

        public GeneralListAssociation() { }
    }
}