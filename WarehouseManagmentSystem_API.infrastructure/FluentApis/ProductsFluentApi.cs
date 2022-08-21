


using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WarehouseManagmentSystem_API.infrastructure.FluentApi
{
    public class ProductsFluentApi : IEntityTypeConfiguration<ProductsEntity>
    {
        public void Configure(EntityTypeBuilder<ProductsEntity> builder)
        {
            builder.HasOne(p => p.CategoriesEntity).WithMany(c => c.Products);
        }
    }
}
