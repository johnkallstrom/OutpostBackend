using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OutpostBackend.Core.Entities;

namespace OutpostBackend.Data.EntityConfigurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(c => c.Id);

            var categories = new List<Category>
            {
                new Category
                {
                    Id = 1,
                    Name = "Movies",
                },
                new Category
                {
                    Id = 2,
                    Name = "Programming",
                },
                new Category
                {
                    Id = 3,
                    Name = "Cities",
                },
                new Category
                {
                    Id = 4,
                    Name = "Plants",
                },
                new Category
                {
                    Id = 5,
                    Name = "Games",
                },
            };

            builder.HasData(categories);
        }
    }
}
