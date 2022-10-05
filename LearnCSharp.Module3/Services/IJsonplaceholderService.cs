using LearnCSharp.Module3.Models;

namespace LearnCSharp.Module3
{
    public interface IJsonplaceholderService
    {
        Task<Post[]> GetPostsAsync();

        Task<Users[]> GetUsersAsync();

        Task<Todos[]> GetTodosAsync();

        Task<Comments[]> GetCommentsAsync();

        Task<Albums[]> GetAlbumsAsync();

        Task<Photos[]> GetPhotosAsync();
    }
}