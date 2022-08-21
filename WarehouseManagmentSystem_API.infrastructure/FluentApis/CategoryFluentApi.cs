using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagmentSystem_API.infrastructure.FluentApi
{
    public class CategoryFluentApi : IEntityTypeConfiguration<CategoriesEntity>
    {
        public void Configure(EntityTypeBuilder<CategoriesEntity> builder)
        {

        }
    }
}
