using CME_Task.Models;
using CME_Task.Repositories;
using Microsoft.AspNetCore.Mvc.Filters;

namespace CME_Task.ActionFilters
{
    public class ValidateCustomerId<T> : IAsyncActionFilter where T : class
    {
        private readonly IHotelRepository hotelDbRepository;
        public ValidateCustomerId(IHotelRepository hotelDbRepository)
        {
            this.hotelDbRepository = hotelDbRepository;
        }
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            Guid customerId = (context.ActionArguments["reservation"] as Reservation).CustomerId;
            Customer entity = await hotelDbRepository.GetRecord<Customer>(customerId);

            if (entity == null)
                throw new Exception("Customer ID is not Found");

            await next();
        }
    
}
}
