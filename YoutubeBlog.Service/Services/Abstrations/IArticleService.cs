using YoutubeBlog.Entity.Entities;

namespace YoutubeBlog.Service.Services.Abstrations
{
    public interface IArticleService
    {
        Task<List<Article>> GetAllArticlesAsync();
    }
}
