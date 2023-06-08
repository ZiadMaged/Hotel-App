using AutoMapper;
using CME_Task.ActionFilters;
using CME_Task.Data;
using CME_Task.Models;
using CME_Task.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CME_Task.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomersController : Controller
    {
        private readonly IHotelRepository hotelDbRepository;
        private readonly IMapper mapper;

        public CustomersController(IHotelRepository hotelDbRepository, IMapper mapper)
        {
            this.hotelDbRepository = hotelDbRepository;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetCustomers()
        {
            IEnumerable<Customer> customers = await hotelDbRepository.GetRecords<Customer>();
            IList<ViewModelCustomer> viewModelcustomers = mapper.Map<IList<ViewModelCustomer>>(customers);

            return Ok(viewModelcustomers);
        }

        [HttpGet("{id}")]
        [ServiceFilter(typeof(ValidationRouteId))]
        [ServiceFilter(typeof(ValidateEntityWithId<Customer>))]
        public async Task<IActionResult> GetCustomer(Guid id)
        {
            Customer record = HttpContext.Items["entity"] as Customer;
            ViewModelCustomer viewModelcustomer = mapper.Map<ViewModelCustomer>(record);

            return Ok(viewModelcustomer);
        }

        [HttpGet("{id}/reservations")]
        [ServiceFilter(typeof(ValidationRouteId))]
        [ServiceFilter(typeof(ValidateEntityWithId<Customer>))]
        [ServiceFilter(typeof(ValidateCustomerReservation))]
        public IActionResult GetReservation(Guid id)
        {
            IList<Reservation> entity = HttpContext.Items["reservations"] as IList<Reservation>;
            IList<ViewModelReservation> reserves = mapper.Map<IList<ViewModelReservation>>(entity);
           
            return Ok(reserves);
        }

        [HttpPost]
        [ServiceFilter(typeof(ValidateCustomerCreation<Customer>))]
        public async Task<IActionResult> AddCustomer(Customer customer)
        {
            Customer createdCustomer = await hotelDbRepository.Add<Customer>(customer);
            ViewModelCustomer viewModelcustomer = mapper.Map<ViewModelCustomer>(createdCustomer);

            return CreatedAtAction(nameof(GetCustomer),
                new { id = viewModelcustomer.Id }, viewModelcustomer);
        }

        [HttpPut("{id}")]
        [ServiceFilter(typeof(ValidationRouteId))]
        [ServiceFilter(typeof(ValidateEntityWithId<Customer>))]
        public async Task<ActionResult> UpdateCustomer(Guid id, Customer customer)
        {
            Customer record = HttpContext.Items["entity"] as Customer;

            record.Name = customer.Name;
            record.Address = customer.Address;
            record.Phone = customer.Phone;
            record.Email = customer.Email;
            record.BirthDate = customer.BirthDate;

            Customer createdCustomer = await hotelDbRepository.Update<Customer>(record);
            ViewModelCustomer viewModelcustomer = mapper.Map<ViewModelCustomer>(createdCustomer);


            return Ok(viewModelcustomer);
        }

        [HttpDelete("{id}")]
        [ServiceFilter(typeof(ValidationRouteId))]
        [ServiceFilter(typeof(ValidateEntityWithId<Customer>))]
        public async Task<ActionResult> DeleteCustomer(Guid id)
        {
            Customer record = HttpContext.Items["entity"] as Customer;
            
            await hotelDbRepository.Delete<Customer>(record);            
            ViewModelCustomer viewModelcustomer = mapper.Map<ViewModelCustomer>(record);

            return Accepted(viewModelcustomer);
        }
    }
}
