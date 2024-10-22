using OutpostBackend.Core.Common.Models;

namespace OutpostBackend.Core.Interfaces
{
    public interface IPostService
    {
        Task<IEnumerable<PostDto>> GetPostsAsync();
    }
}
