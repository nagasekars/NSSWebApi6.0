using NSS.WebAPI.Models.Domain;

namespace NSS.WebAPI.Respository.Abstraction
{
    public interface ICustomerRepository
    {
        Task<IEnumerable<Customer>> GetAllCustomersAsync();
        Task<Customer> GetCustomerAsync(int customerId);

    }
}
