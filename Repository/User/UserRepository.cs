using GeekHub.Database;
using GeekHub.Domains;

namespace GeekHub.Repository.User
{
    public class UserRepository : IUserRepository
    {
        private readonly GeekHubDBContext _context;
        public UserRepository(GeekHubDBContext context)
        {
            _context = context;
        }

        public void AddMovie(int movieId, string movieTitle, string userId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Movie> GetAllMovies(string userId)
        {
            throw new NotImplementedException();
        }
    }
}
