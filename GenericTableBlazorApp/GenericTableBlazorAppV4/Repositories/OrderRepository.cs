using GenericTableBlazorAppV4.Models;
using Microsoft.EntityFrameworkCore;

namespace GenericTableBlazorAppV4.Repositories
{
    public class OrderRepository
    {
        private readonly StoreContext _StoreContext;
        public OrderRepository(StoreContext storeContext)
        {
            _StoreContext = storeContext;
        }
        public async Task<List<OrderModel>> GetAllOrdersAsync()
        {
            return await _StoreContext.Order.ToListAsync();
        }
        public async Task<OrderModel> GetOrderById(int Id)
        {
            OrderModel order = await _StoreContext.Order.FirstOrDefaultAsync(c => c.Id.Equals(Id));
            return order;
        }
        public async Task<bool> InsertOrderAsync(OrderModel order)
        {
            await _StoreContext.Order.AddAsync(order);
            await _StoreContext.SaveChangesAsync();
            return true;
        }
        public async Task<bool> UpdateOrderAsync(OrderModel order)
        {
            _StoreContext.Order.Update(order);
            await _StoreContext.SaveChangesAsync();
            return true;
        }
        public async Task<bool> DeleteOrderAsync(OrderModel order)
        {
            _StoreContext.Order.Remove(order);
            await _StoreContext.SaveChangesAsync();
            return true;
        }
    }
}
