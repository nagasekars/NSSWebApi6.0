using Microsoft.EntityFrameworkCore;
using NSS.WebAPI.Data;
using NSS.WebAPI.Models.Domain;
using NSS.WebAPI.Respository.Abstraction;

namespace NSS.WebAPI.Respository
{
    public class CustomerRespository : ICustomerRepository
    {
        private readonly NSSDbContext dbContext;

        public CustomerRespository(NSSDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<IEnumerable<Customer>> GetAllCustomersAsync()
        {
            return await dbContext.Customer.ToListAsync();
        }

        public async Task<Customer> GetCustomerAsync(int customerId)
        {
            return await dbContext.Customer.FirstOrDefaultAsync(x => x.Id == customerId);
        }
    }
}
