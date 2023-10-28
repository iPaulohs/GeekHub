using GeekHub.Domains;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GeekHub.Database
{
    public class GeekHubDBContext : IdentityDbContext<User,  IdentityRole, string>
    {
        public GeekHubDBContext(DbContextOptions<GeekHubDBContext> options) : base(options) {}
        
        public DbSet<Movie> Movies {  get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<FavoritesListMovies> FavoritesLists { get; set;}
        public DbSet<GeneralListMovies> GeneralLists { get; set; }
        public DbSet<FavoritesListAssociation> FavoritesListAssociations { get; set; }
        public DbSet<GeneralListAssociation> GeneralListsAssociations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>()
                .HasOne(u => u.FavoriteMovies)
                .WithOne(f => f.User)
                .HasForeignKey<FavoritesListMovies>(f => f.ListId)
                .IsRequired(false);

            modelBuilder.Entity<User>()
                .HasMany(u => u.GeneralListMovies)
                .WithOne(f => f.User)
                .HasForeignKey(f => f.ListId)
                .IsRequired(false);

            modelBuilder.Entity<FavoritesListMovies>()
                .HasOne(f => f.User)
                .WithOne(u => u.FavoriteMovies)
                .IsRequired(false);
        }
    }
}
