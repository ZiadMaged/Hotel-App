using CME_Task.Models;
using CME_Task.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.IdentityModel.Tokens;

namespace CME_Task.ActionFilters
{
    public class ValidateCustomerCreation<T> : IAsyncActionFilter where T : class
    {
        private readonly IHotelRepository hotelDbRepository;
        public ValidateCustomerCreation(IHotelRepository hotelDbRepository)
        {
            this.hotelDbRepository = hotelDbRepository;
        }
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            string email = (context.ActionArguments["customer"] as Customer).Email;
            if (email.IsNullOrEmpty())
                throw new Exception("Email is required");

            Customer dbCustomer = await hotelDbRepository.GetCustomerByEmail(email);

            if (dbCustomer != null)
            {
                context.ModelState.AddModelError("Email", "Email already in use");
                context.Result = new UnprocessableEntityObjectResult(context.ModelState);
                return;
            }
            
            await next();
        }
    }
}
