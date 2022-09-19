using NSS.WebAPI.Models.Domain;

namespace NSS.WebAPI.Models.DTO
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string CustomerName { get; set; }

        public int Age { get; set; }

        public Address Address { get; set; }
    }
}
