using OutpostBackend.Core.Common.Models;

namespace OutpostBackend.Core.Interfaces
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryDto>> GetCategoriesAsync();
    }
}
