using GeekHub.Commom;
using GeekHub.Database;

namespace GeekHub.Repository.GeneralList
{
    public class GeneralListRepository : ICommomList
    {
        private readonly GeekHubDBContext _DBContext;

        public GeneralListRepository(GeekHubDBContext geekHubDBContext)
        {
            _DBContext = geekHubDBContext;
        }

        void ICommomList.AddMovieOnList(string listId, int movieId, string titleMovie, Domains.User user)
        {
            throw new NotImplementedException();
        }

        void ICommomList.CreateList(string listName, Domains.User user)
        {
            throw new NotImplementedException();
        }

        void ICommomList.DeleteList(string listId, Domains.User user)
        {
            throw new NotImplementedException();
        }

        void ICommomList.DeleteMovieOnList(string listId, int movieId, string titleMovie, Domains.User user)
        {
            throw new NotImplementedException();
        }

        void ICommomList.GetAllFavoriteMovies(string userId, Domains.User user)
        {
            throw new NotImplementedException();
        }

        internal void GetAllLists(string userId, Domains.User user)
        {
            throw new NotImplementedException();
        }

        void ICommomList.UniqueIdList(string listName, Domains.User user)
        {
            throw new NotImplementedException();
        }
    }
}
