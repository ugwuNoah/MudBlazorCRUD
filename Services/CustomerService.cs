using MudBlazorCRUD3.DataContext;
using MudBlazorCRUD3.Entities;

namespace MudBlazorCRUD3.Services
{
    public class CustomerService: ICustomerService
    {
        private readonly MyContext _dbContext;
        public CustomerService(MyContext context)
        {
            _dbContext = context;
        }
        public void DeleteCustomer(int id)
        {
            var customer = _dbContext.Customers.FirstOrDefault(x => x.Id == id);
            if (customer != null)
            {
                _dbContext.Customers.Remove(customer);
                _dbContext.SaveChanges();
            }
        }
        public Customer GetCustomerById(int id)
        {
            var customer = _dbContext.Customers.SingleOrDefault(x => x.Id == id);
            return customer;
        }
        public List<Customer> GetCustomers()
        {
            return _dbContext.Customers.ToList();
        }
        public void SaveCustomer(Customer customer)
        {
            if (customer.Id == 0) _dbContext.Customers.Add(customer);
            else _dbContext.Customers.Update(customer);
            _dbContext.SaveChanges();
        }
    }
}
