namespace LearnCSharp.Module3
{
    public interface IJsonPlaceholderService<T>
    {
        Task<T[]> GetAllAsync();
    }
}