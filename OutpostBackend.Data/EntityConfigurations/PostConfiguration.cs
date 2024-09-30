using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OutpostBackend.Core.Entities;

namespace OutpostBackend.Data.EntityConfigurations
{
    public class PostConfiguration : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.HasKey(p => p.Id);

            builder
                .HasOne(p => p.Category)
                .WithMany(c => c.Posts)
                .HasForeignKey(p => p.CategoryId);

            var posts = new List<Post>
            {
                new Post
                {
                    Id = 1,
                    Title = "Sample Title 1",
                    Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam dignissim iaculis ex, ut venenatis elit efficitur vel. Interdum et malesuada fames ac ante ipsum primis in faucibus. Ut laoreet venenatis fermentum.",
                    Published = DateTime.Now,
                    CategoryId = 1
                },
                new Post
                {
                    Id = 2,
                    Title = "Sample Title 2",
                    Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam dignissim iaculis ex, ut venenatis elit efficitur vel. Interdum et malesuada fames ac ante ipsum primis in faucibus. Ut laoreet venenatis fermentum.",
                    Published = DateTime.Now,
                    CategoryId = 1
                },
                new Post
                {
                    Id = 3,
                    Title = "Sample Title 3",
                    Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam dignissim iaculis ex, ut venenatis elit efficitur vel. Interdum et malesuada fames ac ante ipsum primis in faucibus. Ut laoreet venenatis fermentum.",
                    Published = DateTime.Now,
                    CategoryId = 1
                },
                new Post
                {
                    Id = 4,
                    Title = "Sample Title 4",
                    Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam dignissim iaculis ex, ut venenatis elit efficitur vel. Interdum et malesuada fames ac ante ipsum primis in faucibus. Ut laoreet venenatis fermentum.",
                    Published = DateTime.Now,
                    CategoryId = 1
                },
                new Post
                {
                    Id = 5,
                    Title = "Sample Title 5",
                    Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam dignissim iaculis ex, ut venenatis elit efficitur vel. Interdum et malesuada fames ac ante ipsum primis in faucibus. Ut laoreet venenatis fermentum.",
                    Published = DateTime.Now,
                    CategoryId = 1
                },
            };

            builder.HasData(posts);
        }
    }
}
