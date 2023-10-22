using GeekHub.Domains;

namespace GeekHub.Commom
{
    public interface ICommomList
    {
        internal void UniqueIdList(string listName, User user);
        internal void CreateList(string listName, User user);
        internal void DeleteList(string listId, User user);
        internal void AddMovieOnList(string listId, int movieId, string titleMovie, User user);
        internal void DeleteMovieOnList(string listId, int movieId, string titleMovie, User user);  
        internal void GetAllFavoriteMovies(string userId, User user);
    }
}
