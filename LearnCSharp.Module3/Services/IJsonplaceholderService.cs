using LearnCSharp.Module3.Models;

namespace LearnCSharp.Module3
{
    public interface IJsonplaceholderService
    {
        Task<Post[]> GetPostsAsync();

        Task<User[]> GetUsersAsync();

        Task<Todo[]> GetTodosAsync();

        Task<Comment[]> GetCommentsAsync();

        Task<Album[]> GetAlbumsAsync();

        Task<Photo[]> GetPhotosAsync();
    }
}