using GeekHub.Domains;

namespace GeekHub.Commom
{
    public interface ICommomList
    {
        internal void UniqueIdList(string listName, string userId);
        internal void CreateList(string listName, string userId);
        internal void DeleteList(string listId, string userId);
        internal void AddMovieOnList(string listId, int movieId, string titleMovie, string userId);
        internal void DeleteMovieOnList(string listId, int movieId, string titleMovie, string userId);  
        internal void GetAllFavoriteMovies(string userId);
    }
}
