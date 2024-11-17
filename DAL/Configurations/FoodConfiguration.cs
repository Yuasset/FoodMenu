using DAL.Data;
using DAL.Models.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Configurations
{
    internal class FoodConfiguration : IEntityTypeConfiguration<Food>
    {
        public void Configure(EntityTypeBuilder<Food> builder)
        {
            builder.HasOne(Food => Food.Category).WithMany(Category => Category.Foods).HasForeignKey(Food => Food.CategoryID);
            builder.HasMany(Food => Food.MenuItems).WithOne(MenuItem => MenuItem.Food).HasForeignKey(Food => Food.FoodID);
            
            builder.HasData(FoodData.Data());
        }
    }
}
