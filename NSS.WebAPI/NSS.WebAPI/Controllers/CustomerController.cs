using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NSS.WebAPI.Models.Domain;
using NSS.WebAPI.Respository.Abstraction;

namespace NSS.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : Controller
    {
        private readonly ICustomerRepository customerRepository;
        private readonly IMapper mapper;

        public CustomerController(ICustomerRepository customerRepository, IMapper mapper)
        {
            this.customerRepository = customerRepository;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCustomers()
        {            
            var customers = await customerRepository.GetAllCustomers();

            if(customers != null)
            {
                var customersDto = mapper.Map<List<Models.DTO.Customer>>(customers);
               return Ok(customersDto);
            }
            return NotFound();
        }

        [HttpGet]
        [Route("id")]
        public async Task<IActionResult> GetCustomer(int id)
        {
            var customer = await customerRepository.GetCustomer(id);
            if(customer != null)
            {
                var customerDto = mapper.Map<Models.DTO.Customer>(customer);
              return  Ok(customerDto);
            }
            return NotFound();
        }
    }
}
