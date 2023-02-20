using GenericTableBlazorAppV4.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GenericTableBlazorAppV4.Repositories
{
    public class StoreContext : DbContext
    {
        public StoreContext()
        {
           

        }

        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            int a = 1;
            int b = 1;
            int d = 1;
            int e = 100;
            string s = DateTime.Now.Nanosecond.ToString();
            base.OnModelCreating(builder);
            builder.Entity<CustomerModel>()
                .HasOne(m => m.OrderModel)
                .WithOne(m => m.CustomerModel)
                .HasForeignKey<OrderModel>(u => u.CustomerModelId)
                .OnDelete(DeleteBehavior.Cascade);
            for (int i = 0; i < e; i++)
            {
                builder.Entity<OrderModel>().HasData(
                new { Id = d, CreateOrderDate = s, CloseOrderDate = s, FullPrice=b , IsCanceled =false, CustomerModelId =a},
                new { PostId = 2, First = "Diego", Last = "Vega" });
            b++;
            a++;
            d++;
            
            }
        }


        public DbSet<CustomerModel> Customer => Set<CustomerModel>();
        public DbSet<OrderModel> Order => Set<OrderModel>();
        public DbSet<ProductModel> Product => Set<ProductModel>();
    }
}
