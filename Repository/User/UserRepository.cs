using GeekHub.Database;
using System.Text.RegularExpressions;

namespace GeekHub.Repository.User
{
    public class UserRepository : IUserRepository
    {
        private readonly GeekHubDBContext _DBContext;

        public UserRepository(GeekHubDBContext geekHubDBContext)
        {
            _DBContext = geekHubDBContext;
        }

        bool IUserRepository.IsValidEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, pattern);
        }

        bool IUserRepository.IsValidPassword(string password)
        {
            throw new NotImplementedException();
        }

        bool IUserRepository.IsValidUserName(string UserName)
        {
            throw new NotImplementedException();
        }

        bool IUserRepository.UniqueEmail(string Email)
        {
            throw new NotImplementedException();
        }

        bool IUserRepository.UniqueId(string Id)
        {
            throw new NotImplementedException();
        }

        bool IUserRepository.UniqueUsername(string UserName)
        {
            throw new NotImplementedException();
        }
    }
}
