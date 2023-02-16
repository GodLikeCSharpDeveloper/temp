using GenericTableBlazorAppV4.Models;
using Microsoft.EntityFrameworkCore;

namespace GenericTableBlazorAppV4.Repositories
{
    public class StoreContext :DbContext
    {
        public StoreContext()
        {

        }

        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        {

        }

        public DbSet<CustomerModel> Customer => Set<CustomerModel>();
        public DbSet<OrderModel> Order => Set<OrderModel>();
        public DbSet<ProductModel> Product => Set<ProductModel>();
    }
}
