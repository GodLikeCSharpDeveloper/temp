using GenericTableBlazorAppV4.Models;
using Microsoft.EntityFrameworkCore;

namespace GenericTableBlazorAppV4.Repositories
{
    public class ProductRepository
    {
        private readonly StoreContext _StoreContext;
        public ProductRepository(StoreContext storeContext)
        {
            _StoreContext = storeContext;
        }
        public async Task<List<ProductModel>> GetAllOrdersAsync()
        {
            return await _StoreContext.Product.ToListAsync();
        }
        public async Task<ProductModel> GetOrderById(int Id)
        {
            ProductModel product = await _StoreContext.Product.FirstOrDefaultAsync(c => c.Id.Equals(Id));
            return product;
        }
        public async Task<bool> InsertOrderAsync(ProductModel product)
        {
            await _StoreContext.Product.AddAsync(product);
            await _StoreContext.SaveChangesAsync();
            return true;
        }
        public async Task<bool> UpdateOrderAsync(ProductModel product)
        {
            _StoreContext.Product.Update(product);
            await _StoreContext.SaveChangesAsync();
            return true;
        }
        public async Task<bool> DeleteOrderAsync(ProductModel product)
        {
            _StoreContext.Product.Remove(product);
            await _StoreContext.SaveChangesAsync();
            return true;
        }
    }
}
