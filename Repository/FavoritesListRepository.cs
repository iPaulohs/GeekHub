using GeekHub.Commom;

namespace GeekHub.Repository
{
    public class FavoritesListRepository : ICommomList
    {
        void ICommomList.AddMovieOnList(string listId, int movieId, string titleMovie, string userId)
        {
            throw new NotImplementedException();
        }

        void ICommomList.CreateList(string listName, string userId)
        {
            throw new NotImplementedException();
        }

        void ICommomList.DeleteList(string listId, string userId)
        {
            throw new NotImplementedException();
        }

        void ICommomList.DeleteMovieOnList(string listId, int movieId, string titleMovie, string userId)
        {
            throw new NotImplementedException();
        }

        void ICommomList.GetAllFavoriteMovies(string userId)
        {
            throw new NotImplementedException();
        }

        void ICommomList.UniqueIdList(string listName, string userId)
        {
            throw new NotImplementedException();
        }
    }
}
