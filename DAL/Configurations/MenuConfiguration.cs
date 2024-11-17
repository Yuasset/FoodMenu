using DAL.Data;
using DAL.Models.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Configurations
{
    internal class MenuConfiguration : IEntityTypeConfiguration<Menu>
    {
        public void Configure(EntityTypeBuilder<Menu> builder)
        {
            builder.HasMany(Menu => Menu.MenuItems).WithOne(MenuItem => MenuItem.Menu).HasForeignKey(Menu => Menu.MenuID);
            
            builder.HasData(MenuData.Data());
        }
    }
}
