using Microsoft.EntityFrameworkCore;
using NSS.WebAPI.Models.Domain;

namespace NSS.WebAPI.Data
{
    public class NSSDbContext : DbContext
    {
        public NSSDbContext(DbContextOptions<NSSDbContext> options) : base(options)
        {

        }

        public DbSet<Customer> Customer { get; set; }

        public DbSet<Address> Address { get; set; }

        public DbSet<Contact> Contact { get; set; }


    }
}
