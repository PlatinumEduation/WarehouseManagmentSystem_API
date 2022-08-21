using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagmentSystem_API.infrastructure
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryFluentApi());
            modelBuilder.ApplyConfiguration(new ProductsFluentApi());

            modelBuilder.Entity<OrderItems>()
                .HasOne(o => o.OrdersEntity) // has one order >> and the order has many items 
                .WithMany(oi => oi.OrderItems)
                .HasForeignKey(oi => oi.Order_Id); // fk is the orderId


            modelBuilder.Entity<OrderItems>()
                .HasOne(o => o.ProductsEntity) 
                .WithMany(oi => oi.OrderItems)
                .HasForeignKey(oi => oi.Product_Id);

            modelBuilder.Entity<OrdersEntity>()
                .HasOne(o => o.CustomersEntity)
                .WithMany(c => c.OrdersEntities);



        }

        // Creating dbset for the tables in db
        public DbSet<CategoriesEntity> Categories { get; set; }
        public DbSet<ProductsEntity> Products { get; set; }
        public DbSet<OrdersEntity> Orders { get; set; }
        public DbSet<OrderItems> Order_Items { get; set; }
        public DbSet<EmployeesEntity> Employees { get; set; }
        public DbSet<CustomerEntity> Customers { get; set; }

    }
}
