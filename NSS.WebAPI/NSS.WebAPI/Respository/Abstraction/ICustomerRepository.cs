using NSS.WebAPI.Models.Domain;

namespace NSS.WebAPI.Respository.Abstraction
{
    public interface ICustomerRepository
    {
        Task<IEnumerable<Customer>> GetAllCustomers();
        Task<Customer> GetCustomer(int customerId);

    }
}
