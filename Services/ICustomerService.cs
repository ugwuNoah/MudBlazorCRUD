using MudBlazorCRUD3.Entities;

namespace MudBlazorCRUD3.Services
{
    public interface ICustomerService
    {
        List<Customer> GetCustomers();
        Customer GetCustomerById(int id);
        void SaveCustomer(Customer customer);
        void DeleteCustomer(int id);
    }
}
