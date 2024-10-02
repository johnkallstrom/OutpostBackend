using AutoMapper;
using OutpostBackend.Core.Common.Models;
using OutpostBackend.Core.Entities;
using OutpostBackend.Core.Interfaces;

namespace OutpostBackend.Api.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IMapper _mapper;
        private readonly IGenericService<Category> _genericService;

        public CategoryService(IGenericService<Category> genericService, IMapper mapper)
        {
            _genericService = genericService;
            _mapper = mapper;
        }

        public async Task<IEnumerable<CategoryDto>> GetCategoriesAsync()
        {
            var categories = await _genericService.GetListAsync();
            return _mapper.Map<IEnumerable<CategoryDto>>(categories);
        }
    }
}
