using GeekHub.Domains;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GeekHub.Database
{
    public class GeekHubDBContext : IdentityDbContext
    {
        public GeekHubDBContext(DbContextOptions<GeekHubDBContext> options) : base(options) {}
        
        public DbSet<Movie> Movies {  get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<FavoritesListMovies> FavoritesLists { get; set;}
        public DbSet<GeneralListMovies> GeneralLists { get; set; }
        public DbSet<FavoritesListAssociation> FavoritesListAssociations { get; set; }
        public DbSet<GeneralListAssociation> GeneralListsAssociations { get; set; }
    }
}
