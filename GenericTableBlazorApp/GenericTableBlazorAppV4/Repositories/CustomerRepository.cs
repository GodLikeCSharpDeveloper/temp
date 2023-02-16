using GenericTableBlazorAppV4.Models;
using Microsoft.EntityFrameworkCore;

namespace GenericTableBlazorAppV4.Repositories
{
    public class CustomerRepository
    {
        private readonly StoreContext _StoreContext;
        public CustomerRepository(StoreContext storeContext)
        {
            _StoreContext = storeContext;
        }
        public async Task<List<CustomerModel>> GetAllCustomersAsync()
        {
            return await _StoreContext.Customer.ToListAsync();
        }
        public async Task<CustomerModel> GetCustomerById(int Id)
        {
            CustomerModel customer = await _StoreContext.Customer.FirstOrDefaultAsync(c => c.Id.Equals(Id));
            return customer;
        }
        public async Task<bool> InsertCustomerAsync(CustomerModel customer)
        {
            await _StoreContext.Customer.AddAsync(customer);
            await _StoreContext.SaveChangesAsync();
            return true;
        }
        public async Task<bool> UpdateCustomerAsync(CustomerModel customer)
        {
            _StoreContext.Customer.Update(customer);
            await _StoreContext.SaveChangesAsync();
            return true;
        }
        public async Task<bool> DeleteCustomerAsync(CustomerModel customer)
        {
            _StoreContext.Customer.Remove(customer);
            await _StoreContext.SaveChangesAsync();
            return true;
        }
    }
}
