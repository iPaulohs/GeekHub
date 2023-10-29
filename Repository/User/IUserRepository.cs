using GeekHub.Domains;

namespace GeekHub.Repository.User
{
    public interface IUserRepository
    {
        public IEnumerable<Movie> GetAllMovies(string userId);
        public void AddMovie(int movieId, string movieTitle, string userId);
    }
}
