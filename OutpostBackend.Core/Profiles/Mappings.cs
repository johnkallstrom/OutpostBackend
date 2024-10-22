using AutoMapper;
using OutpostBackend.Core.Common.Models;
using OutpostBackend.Core.Entities;

namespace OutpostBackend.Api.Profiles
{
    public class Mappings : Profile
    {
        public Mappings()
        {
            // Categories
            CreateMap<Category, CategoryDto>();

            // Posts
            CreateMap<Post, PostDto>();
        }
    }
}
