using AutoMapper;
using OutpostBackend.Core.Common.Models;
using OutpostBackend.Core.Entities;
using OutpostBackend.Core.Interfaces;

namespace OutpostBackend.Api.Services
{
    public class PostService : IPostService
    {
        private readonly IMapper _mapper;
        private readonly IGenericService<Post> _genericService;

        public PostService(IGenericService<Post> genericService, IMapper mapper)
        {
            _genericService = genericService;
            _mapper = mapper;
        }

        public async Task<IEnumerable<PostDto>> GetPostsAsync()
        {
            var posts = await _genericService.GetListAsync();
            return _mapper.Map<IEnumerable<PostDto>>(posts);
        }
    }
}
