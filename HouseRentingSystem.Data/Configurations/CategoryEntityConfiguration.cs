using HouseRentingSystem.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HouseRentingSystem.Data.Configurations
{
    public class CategoryEntityConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(GenerateCategories());
        }
        private List<Category> GenerateCategories()
        {
            var categories = new List<Category>();

            Category category;

            category = new Category()
            {
                Id=1,
                Name="Cottage"
            };

            categories.Add(category);

            category = new Category()
            {
                Id = 2,
                Name = "Single-Family"
            };

            categories.Add(category);

            category = new Category()
            {
                Id = 3,
                Name = "Duplex"
            };

            categories.Add(category);

            return categories;
        }
    }
}
