using OutpostBackend.Core.Common.Models;
using OutpostBackend.Core.Entities;
using OutpostBackend.Core.Interfaces;

namespace OutpostBackend.Api.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IMapper
        private readonly IGenericService<Category> _genericService;

        public CategoryService(IGenericService<Category> genericService)
        {
            _genericService = genericService;
        }

        public Task<IEnumerable<CategoryDto>> GetCategoriesAsync()
        {
        }
    }
}
