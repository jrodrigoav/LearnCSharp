using LearnCSharp.Module3.Models;

namespace LearnCSharp.Module3
{
    public interface IJsonplaceholderService
    {
        Task<Post[]> GetPostsAsync();
    }
}